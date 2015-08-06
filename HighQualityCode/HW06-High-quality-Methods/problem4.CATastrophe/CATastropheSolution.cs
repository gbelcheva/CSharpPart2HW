namespace ConsoleApplication4
{
    using System;
    using System.Collections.Generic;

    public class CATastropheSolution
    {
        public static void Main(string[] args)
        {
            int numberOfCSharpCodeLines = int.Parse(Console.ReadLine());
            string[] codeLines = new string[numberOfCSharpCodeLines];

            for (int i = 0; i < numberOfCSharpCodeLines; i++)
            {
                codeLines[i] = Console.ReadLine().Trim();
            }

            string[] primitiveTypes = 
            { 
                  "sbyte",
                  "byte",
                  "short",
                  "ushort",
                  "int",
                  "uint",
                  "long",
                  "ulong",
                  "float",
                  "double",
                  "decimal",
                  "bool",
                  "char",
                  "string",
                  "sbyte?",
                  "byte?",
                  "short?",
                  "ushort?",
                  "int?",
                  "uint?",
                  "long?",
                  "ulong?",
                  "float?",
                  "double?",
                  "decimal?",
                  "bool?",
                  "char?",
                  "string?"
            };

            string[] scopes = 
            {         
                  "if ",
                  "else ",
                  "for ",
                  "while ",
                  "foreach "
            };

            List<string> conditionalVariables = new List<string>();
            List<string> loopVariables = new List<string>();
            List<string> methodVariables = new List<string>();

            bool inMethod = true;
            int methodBracketsCount = 0;

            for (int lineNumber = 0; lineNumber < codeLines.Length; lineNumber++)
            {
                int startIndexInString = 0;

                string[] wordsInCurrentLine = codeLines[lineNumber].Split(new char[] { ' ', ')', '(', '=', ',' }, StringSplitOptions.RemoveEmptyEntries);

                if (wordsInCurrentLine.Length < 1)
                {
                    continue;
                }

                if (wordsInCurrentLine[0] == "static")
                {
                    inMethod = true;
                }

                while (inMethod)
                {
                    if (lineNumber > codeLines.Length - 1)
                    {
                        break;
                    }

                    startIndexInString = 0;

                    while (codeLines[lineNumber].IndexOf("\"") >= 0)
                    {
                        startIndexInString = codeLines[lineNumber].IndexOf("\"");
                        int endIndexString = codeLines[lineNumber].IndexOf("\"", startIndexInString + 1);
                        codeLines[lineNumber] = codeLines[lineNumber].Remove(startIndexInString, endIndexString - startIndexInString + 1);
                    }

                    wordsInCurrentLine = codeLines[lineNumber].Split(new char[] { ' ', ')', '(', '=', ',' }, StringSplitOptions.RemoveEmptyEntries);

                    if (wordsInCurrentLine.Length < 1)
                    {
                        lineNumber++;
                        continue;
                    }

                    if (lineNumber > codeLines.Length - 1)
                    {
                        break;
                    }

                    if (wordsInCurrentLine[0] == "if" || wordsInCurrentLine[0] == "else")
                    {
                        lineNumber = SearchInsideCondition(primitiveTypes, codeLines, lineNumber, conditionalVariables, loopVariables) + 1;

                        continue;
                    }

                    if (wordsInCurrentLine[0] == "for" || wordsInCurrentLine[0] == "while" || wordsInCurrentLine[0] == "foreach")
                    {
                        lineNumber = SearchInsideLoop(primitiveTypes, codeLines, lineNumber, loopVariables, conditionalVariables) + 1;

                        continue;
                    }

                    for (int wordIndex = 0; wordIndex < wordsInCurrentLine.Length - 1; wordIndex++)
                    {
                        for (int primitiveTypesIndex = 0; primitiveTypesIndex < primitiveTypes.Length; primitiveTypesIndex++)
                        {
                            if (wordsInCurrentLine[wordIndex] == primitiveTypes[primitiveTypesIndex])
                            {
                                if (wordIndex == 1)
                                {
                                    if (wordsInCurrentLine[wordIndex - 1] != "static" && (char.IsDigit(wordsInCurrentLine[wordIndex + 1][0]) || char.IsLetter(wordsInCurrentLine[wordIndex + 1][0]) || wordsInCurrentLine[wordIndex + 1][0] == '?'))
                                    {
                                        if (wordsInCurrentLine[wordIndex + 1][0] == '?')
                                        {
                                            methodVariables.Add(wordsInCurrentLine[wordIndex + 2]);
                                        }
                                        else
                                        {
                                            methodVariables.Add(wordsInCurrentLine[wordIndex + 1]);
                                        }
                                    }
                                }
                                else if (char.IsDigit(wordsInCurrentLine[wordIndex + 1][0]) || char.IsLetter(wordsInCurrentLine[wordIndex + 1][0]) || wordsInCurrentLine[wordIndex + 1][0] == '?')
                                {
                                    if (wordsInCurrentLine[wordIndex + 1][0] == '?')
                                    {
                                        methodVariables.Add(wordsInCurrentLine[wordIndex + 2]);
                                    }
                                    else
                                    {
                                        methodVariables.Add(wordsInCurrentLine[wordIndex + 1]);
                                    }
                                }
                            }
                        }
                    }

                    lineNumber++;

                    if (lineNumber > codeLines.Length - 1)
                    {
                        break;
                    }

                    codeLines[lineNumber] = codeLines[lineNumber].Trim();

                    if (codeLines[lineNumber].IndexOf("{") == 0)
                    {
                        methodBracketsCount++;
                    }

                    if (codeLines[lineNumber].IndexOf("}") == 0)
                    {
                        methodBracketsCount--;
                    }

                    if (methodBracketsCount == 0)
                    {
                        inMethod = false;

                        break;
                    }

                    GC.Collect();
                }

                if (lineNumber > codeLines.Length - 1)
                {
                    break;
                }
            }

            if (methodVariables.Count > 0)
            {
                Console.WriteLine("Methods -> " + methodVariables.Count + " -> " + string.Join(", ", methodVariables));
            }
            else
            {
                Console.WriteLine("Methods -> None");
            }

            if (loopVariables.Count > 0)
            {
                Console.WriteLine("Loops -> " + loopVariables.Count + " -> " + string.Join(", ", loopVariables));
            }
            else
            {
                Console.WriteLine("Loops -> None");
            }

            if (conditionalVariables.Count > 0)
            {
                Console.WriteLine("Conditional Statements -> " + conditionalVariables.Count + " -> " + string.Join(", ", conditionalVariables));
            }
            else
            {
                Console.WriteLine("Conditional Statements -> None");
            }
        }

        private static int SearchInsideLoop(
            string[] primitiveTypes,
            string[] codeLines,
            int lineNumber,
            List<string> loopVariables,
            List<string> conditionalVariables)
        {
            int loopBracketsCount = 0;

            while (true)
            {
                if (lineNumber > codeLines.Length - 1)
                {
                    break;
                }

                int startIndexInString = 0;

                codeLines[lineNumber].Replace("  ", " ");

                while (codeLines[lineNumber].IndexOf("\"") >= 0)
                {
                    startIndexInString = codeLines[lineNumber].IndexOf("\"");
                    int endIndexInString = codeLines[lineNumber].IndexOf("\"", startIndexInString + 1);
                    codeLines[lineNumber] = codeLines[lineNumber].Remove(startIndexInString, endIndexInString - startIndexInString + 1);
                }

                string[] wordsInCurrentLine = codeLines[lineNumber].Split(new char[] { ' ', ')', '(', '=', ',' }, StringSplitOptions.RemoveEmptyEntries);

                if (wordsInCurrentLine.Length < 1)
                {
                    lineNumber++;

                    continue;
                }

                if (lineNumber > codeLines.Length - 1)
                {
                    break;
                }

                if (wordsInCurrentLine[0] == "if" || wordsInCurrentLine[0] == "else")
                {
                    lineNumber = SearchInsideCondition(primitiveTypes, codeLines, lineNumber, conditionalVariables, loopVariables) + 1;
                    continue;
                }

                for (int wordIndex = 0; wordIndex < wordsInCurrentLine.Length - 1; wordIndex++)
                {
                    for (int k = 0; k < primitiveTypes.Length; k++)
                    {
                        if (wordsInCurrentLine[wordIndex] == primitiveTypes[k] && (char.IsDigit(wordsInCurrentLine[wordIndex + 1][0]) || char.IsLetter(wordsInCurrentLine[wordIndex + 1][0]) || wordsInCurrentLine[wordIndex + 1][0] == '?'))
                        {
                            if (wordsInCurrentLine[wordIndex + 1][0] == '?')
                            {
                                loopVariables.Add(wordsInCurrentLine[wordIndex + 2]);
                            }
                            else
                            {
                                loopVariables.Add(wordsInCurrentLine[wordIndex + 1]);
                            }
                        }
                    }
                }

                lineNumber++;

                if (lineNumber > codeLines.Length - 1)
                {
                    break;
                }

                codeLines[lineNumber] = codeLines[lineNumber].Trim();

                if (codeLines[lineNumber].IndexOf("{") == 0)
                {
                    loopBracketsCount++;
                }

                if (codeLines[lineNumber].IndexOf("}") == 0)
                {
                    loopBracketsCount--;
                }

                if (loopBracketsCount == 0)
                {
                    break;
                }
            }

            return lineNumber;
        }

        private static int SearchInsideCondition(
            string[] primitiveTypes,
            string[] codeLines,
            int lineNumber,
            List<string> conditionalVariables,
            List<string> loopVariables)
        {
            int conditionBracketsCount = 0;

            while (true)
            {
                if (lineNumber > codeLines.Length - 1)
                {
                    break;
                }

                int startIndexInString = 0;

                codeLines[lineNumber].Replace("  ", " ");

                while (codeLines[lineNumber].IndexOf("\"") >= 0)
                {
                    startIndexInString = codeLines[lineNumber].IndexOf("\"");
                    int endIndexInString = codeLines[lineNumber].IndexOf("\"", startIndexInString + 1);
                    codeLines[lineNumber] = codeLines[lineNumber].Remove(startIndexInString, endIndexInString - startIndexInString + 1);
                }

                string[] wordsInCurrentLine = codeLines[lineNumber].Split(new char[] { ' ', ')', '(', '=', ',' }, StringSplitOptions.RemoveEmptyEntries);

                if (wordsInCurrentLine.Length < 1)
                {
                    lineNumber++;

                    continue;
                }

                if (lineNumber > codeLines.Length - 1)
                {
                    break;
                }

                if (wordsInCurrentLine[0] == "for" || wordsInCurrentLine[0] == "while" || wordsInCurrentLine[0] == "foreach")
                {
                    lineNumber = SearchInsideLoop(primitiveTypes, codeLines, lineNumber, loopVariables, conditionalVariables) + 1;

                    continue;
                }

                for (int wordIndex = 0; wordIndex < wordsInCurrentLine.Length - 1; wordIndex++)
                {
                    for (int k = 0; k < primitiveTypes.Length; k++)
                    {
                        if (wordsInCurrentLine[wordIndex] == primitiveTypes[k] && (char.IsDigit(wordsInCurrentLine[wordIndex + 1][0]) || char.IsLetter(wordsInCurrentLine[wordIndex + 1][0]) || wordsInCurrentLine[wordIndex + 1][0] == '?'))
                        {
                            if (wordsInCurrentLine[wordIndex + 1][0] == '?')
                            {
                                conditionalVariables.Add(wordsInCurrentLine[wordIndex + 2]);
                            }
                            else
                            {
                                conditionalVariables.Add(wordsInCurrentLine[wordIndex + 1]);
                            }
                        }
                    }
                }

                lineNumber++;

                if (lineNumber > codeLines.Length - 1)
                {
                    break;
                }

                codeLines[lineNumber] = codeLines[lineNumber].Trim();

                if (codeLines[lineNumber].IndexOf("{") == 0)
                {
                    conditionBracketsCount++;
                }

                if (codeLines[lineNumber].IndexOf("}") == 0)
                {
                    conditionBracketsCount--;
                }

                if (conditionBracketsCount == 0)
                {
                    break;
                }
            }

            return lineNumber;
        }
    }
}