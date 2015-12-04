/**********************************************************************************
 *
 * Purpose: Conventer C++ to C# 
 * Method: Using C# Programming Language
 * Author: 2005510040-Kemal Þaybakan
 * Date: 07.06.2009
 * Assumptions: I don't need any assumption !!!
 * 
 **********************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace _005510040_Conventer
{
    /***************************************************************************** 
    /    Program is building with 3 parts. Library, class, main ...
    /    Main -> with codeMain() function
    /    Library -> with codeLibrary() function
    /    Class -> with codeClass() function
    *****************************************************************************/
    public partial class FormCon : Form
    {
        /* initialize global variables */ 

        RichTextBox rTxtCs = new RichTextBox(); // Implementation Rich Text Box for C# Code
        private string strSaveFileName; // Save File Name
        private string className = "Undeclared"; // If there exists class, put class name
        private bool bLibrary = false; // which part library
        private bool bClass = true; // which part class
        private bool bMain = true; // which part main
        private bool bUsingSystem = false; // if program is using system command
        private bool bPublicPrefix = false; // if public variables exists
        private bool bPrivatePrefix = false; // if private variables exists
        private bool bProtectedPrefix = false; // if protected variables exists
        private string strPrefix = ""; // prefix for class type public, private, proctected
        private int iOpenCloseParNum = 0; // determine open close paranthesis

        // Initialize Form Component
        public FormCon()
        {
            InitializeComponent();
        }

        // Close Program
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /***************************************************************************** 
            Purpose: Go to ConvertToCSharp function
            Inputs:  button parameters 
            Returns: Return value nothing.
        *****************************************************************************/
        private void btnConvertFromCpp_Click(object sender, EventArgs e)
        {
            // Go to ConvertToCSharp function
            rTxtCSharpCode.Text = ConvertToCSharp(rTxtCppCode).Text;
        }

        /***************************************************************************** 
            Purpose: Open c++ file type and Load to rich text file
            Inputs:  button parameters
            Returns: Return value nothing. It pushes value to stack 
        *****************************************************************************/
        private void btnOpenFileCpp_Click(object sender, EventArgs e)
        {
            string chosenFile = "";

            // Determine open file dialog properties
            openFileCSharp.Title = "Open a C++ File";
            openFileCSharp.FileName = "";
            openFileCSharp.Filter = "C++ Files|*.cpp";

            if (openFileCSharp.ShowDialog() != DialogResult.Cancel)
            {
                // if user wants to open and click ok
                chosenFile = openFileCSharp.FileName;
                rTxtCppCode.LoadFile(chosenFile, RichTextBoxStreamType.PlainText);
                strSaveFileName = chosenFile;
            }
        }

        /***************************************************************************** 
            Purpose: Convert Cpp library to C# library
            Inputs:  strLine(one line rich text box) 
            Returns: True -> ok, pass main or class , False -> go on library
        *****************************************************************************/
        private bool codeLibrary(string strLine)
        {
            // Convert #include <iostream> to using System;
            if (strLine.Trim().StartsWith("#include") && (strLine.ToLower().Contains("<iostream>")))
            {
                if(bUsingSystem == false) rTxtCs.Text += "using System;" + "\n";
                bUsingSystem = true;
                return false;
            }

            // Convert #include <windows.h> to using System.Windows.Forms;
            if (strLine.Trim().StartsWith("#include") && strLine.ToLower().Contains("<windows.h>") == true)
            {
                rTxtCs.Text += "using System.Windows.Forms;" + "\n";
                return false;
            }

            // Convert #include <string> to using System.Text;
            if (strLine.Trim().StartsWith("#include") && strLine.ToLower().Contains("<string>") == true)
            {
                rTxtCs.Text += "using System.Text;" + "\n";
                return false;
            }

            // Convert using namespace std to blank;
            if ((strLine.Trim().Contains("using namespace std") || strLine.Trim().Contains("using std::")) == true)
            {
                rTxtCs.Text += "";
                return false;
            }

            return true;
        }

        /***************************************************************************** 
            Purpose: Convert Cpp class code to C# class code
            Inputs:  strLine(one line rich text box)
            Returns: True -> ok, pass main , False -> go on class
        *****************************************************************************/
        private bool codeClass(string strLine)
        {
            int iLen;

            // Convert std::string to string;
            if (strLine.Trim().Contains("std::string") == true)
            {
                strLine = strLine.Replace("std::string", "string");
            }

            // Convert if(variable) to if(variable != 0)
            if (strLine.Trim().Contains("if") == true && strLine.Trim().Contains("==") == false && strLine.Trim().Contains("!=") == false)
            {
                int start = strLine.IndexOf("(");
                int finish = strLine.IndexOf(")");
                int count = finish - start; // variable length
                string var = strLine.Substring(start + 1, count-1);
                strLine = strLine.Replace(var, var + " != 0");
            }

            // Convert class className to class
            if (strLine.Trim().Contains("class") == true && strLine.Trim().Contains("{") == false)
            {
                className = strLine.Substring(6);
                rTxtCs.Text += strLine.Trim() + "\n";
                return false;
            }

            // Convert class className{ to class
            //                             { 
            if (strLine.Trim().Contains("class") == true && strLine.Trim().Contains("{") == true)
            {
                iLen = strLine.IndexOf('{');
                iLen = iLen - 7;
                className = strLine.Substring(6, iLen+1);

                iLen = strLine.IndexOf("{");
                strLine = strLine.Remove(iLen);

                rTxtCs.Text += strLine.Trim() + "\n" + "{\n";
                iOpenCloseParNum++;
                return false;
            }

            // Convert cout to Console.Write or Console.Writeline
            if ((strLine.Trim().StartsWith("cout") == true) || (strLine.Trim().StartsWith("std::cout") == true))
            {
                strLine = strLine.Replace("std::cout <<", "\tConsole.Write(");
                strLine = strLine.Replace("cout <<", "\tConsole.Write(");
                strLine = strLine.Replace("<< std::endl", " + \"\\n\"");
                strLine = strLine.Replace("<< endl", " + \"\\n\"");
                strLine = strLine.Replace("std::cout<<", "\tConsole.Write(");
                strLine = strLine.Replace("cout<<", "\tConsole.Write(");
                strLine = strLine.Replace("<<endl", " + \"\\n\"");
                strLine = strLine.Replace("<<std::endl", " + \"\\n\"");
                strLine = strLine.Replace(";", ");");
                strLine = strLine.Replace("<<", "+");
                rTxtCs.Text += strLine + "\n";
                return false;
            }

            // Convert cout to Console.Read or Console.Readline
            if ((strLine.Trim().Contains("cin >>") == true) || (strLine.Trim().StartsWith("cin >>") == true))
            {
                strLine = strLine.Replace("std::cin >>", "");
                strLine = strLine.Replace("std::cin>>", "");
                strLine = strLine.Replace("cin >>", "");
                strLine = strLine.Replace(";", "");
                strLine = strLine.Replace("cin>>", "");
                strLine = strLine + " = Console.ReadLine();";
                rTxtCs.Text += "\t" + strLine + "\n";
                return false;
            }

            // if strLine starts with };, end of class
            if (strLine.Trim().StartsWith("};") == true)
            {
                // Determine for class type 
                bPublicPrefix = false;
                bPrivatePrefix = false;
                bProtectedPrefix = false;
                return true;
            }

            // if strLine starts with public:,
            if (strLine.Trim().StartsWith("public:") == true)
            {
                // Determine for class type
                strPrefix = "\tpublic ";
                bPublicPrefix = true;
                bPrivatePrefix = false;
                bProtectedPrefix = false;
                return false;
            }

            // if strLine starts with private:,
            if (strLine.Trim().StartsWith("private:") == true)
            {
                // Determine for class type
                strPrefix = "\tprivate ";
                bPrivatePrefix = true;
                bPublicPrefix = false;
                bProtectedPrefix = false;
                return false;
            }

            // if strLine starts with protected:
            if (strLine.Trim().StartsWith("protected:") == true)
            {
                // Determine for class type
                strPrefix = "\tprotected ";
                bProtectedPrefix = true;
                bPrivatePrefix = false;
                bPublicPrefix = false;
                return false;
            }

            // if strLine contains {
            if (strLine.Trim().Contains("{") == true)
            {
                rTxtCs.Text += strLine + "\n";
                iOpenCloseParNum++;
                return false;
            }

            // if strLine contains }
            if (strLine.Trim().Contains("}") == true)
            {
                rTxtCs.Text += strLine + "\n";
                iOpenCloseParNum--;
                return false;
            }

            // if normal line exists except public, private, protected
            if ((bProtectedPrefix == true || bPrivatePrefix == true || bPublicPrefix == true))
            {
                if (iOpenCloseParNum < 3)
                {
                    if (iOpenCloseParNum % 2 == 0)
                        rTxtCs.Text += strLine + "\n"; // without clas type prefix
                    else
                        rTxtCs.Text += strPrefix + strLine.Trim() + "\n"; // with clas type prefix
                }
                else 
                {
                    rTxtCs.Text += strLine + "\n";
                }
                return false;
            }

            return true;
        }

        /***************************************************************************** 
            Purpose: Convert Cpp main code to C# main code
            Inputs:  strLine(one line rich text box) 
            Returns: True -> finish program , False -> go on class
        *****************************************************************************/
        private bool codeMain(string strLine)
        {
            int iLen;

            // if strLine starts with {, convert
            if (strLine.Trim().StartsWith("{") == true)
            {
                rTxtCs.Text += "\t" + strLine + "\n";
                iOpenCloseParNum++;
                return false;
            }

            // convert std::string to string 
            if (strLine.Trim().Contains("std::string") == true)
            {
                strLine = strLine.Replace("std::string", "string");
            }

            // convert if(variable) to if(variable != 0) 
            if (strLine.Trim().Contains("if") == true && strLine.Trim().Contains("==") == false && strLine.Trim().Contains("!=") == false)
            {
                int start = strLine.IndexOf("(");
                int finish = strLine.IndexOf(")");
                int count = finish - start; // variable count
                string var = strLine.Substring(start + 1, count - 1);
                strLine = strLine.Replace(var, var + " != 0");
            }

            // if strLine start with };, end of program
            if (strLine.Trim().StartsWith("};") == true)
            {
                return false;
            }

            // if strLine start with }, decrease iOpenCloseParNum
            if (strLine.Trim().Contains("}") == true)
            {
                rTxtCs.Text += "\t" + strLine + "\n";
                iOpenCloseParNum--;
                return false;
            }

            // Convert cout to Console.Write or Console.Writeline
            if ((strLine.Trim().StartsWith("cout") == true) || (strLine.Trim().StartsWith("std::cout") == true))
            {
                strLine = strLine.Replace("std::cout <<", "\tConsole.Write(");
                strLine = strLine.Replace("cout <<", "\tConsole.Write(");
                strLine = strLine.Replace("<< std::endl", " + \"\\n\"");
                strLine = strLine.Replace("<< endl", " + \"\\n\"");
                strLine = strLine.Replace("std::cout<<", "\tConsole.Write(");
                strLine = strLine.Replace("cout<<", "\tConsole.Write(");
                strLine = strLine.Replace("<<endl", " + \"\\n\"");
                strLine = strLine.Replace("<<std::endl", " + \"\\n\"");
                strLine = strLine.Replace(";", ");");
                strLine = strLine.Replace("<<", "+");
                rTxtCs.Text += strLine + "\n";
                return false;
            }

            // Convert cout to Console.Read or Console.Readline
            if ((strLine.Trim().Contains("cin >>") == true) || (strLine.Trim().StartsWith("cin >>") == true))
            {
                strLine = strLine.Replace("std::cin >>", "");
                strLine = strLine.Replace("std::cin>>", "");
                strLine = strLine.Replace("cin >>", "");
                strLine = strLine.Replace(";", "");
                strLine = strLine.Replace("cin>>", "");
                strLine = strLine + " = Console.ReadLine();";
                rTxtCs.Text += "\t" + strLine + "\n";
                return false;
            }

            // Convert className.subField to className cl = new className();
            if ((strLine.Trim().StartsWith(className) == true) && (strLine.Trim().Contains(".") == false))
            {
                strLine = strLine.Replace(";", " = new ") + className + "();";
                rTxtCs.Text += "\t" + strLine + "\n";
                return false;
            }

            // Convert main cases
            if (strLine.Trim().Contains("main(") == true)
            {
                // if it contins {, increase iOpenCloseParNum
                if (strLine.Trim().Contains("{")) iOpenCloseParNum++;

                rTxtCs.Text += "\t";

                // for example void main -> main
                int foundS1 = strLine.Trim().IndexOf("main");
                strLine = strLine.Remove(0, foundS1);

                // main -> static void Main
                // () -> (string[] args)
                // (int argc, char *argv) -> (string[] args)
                string strBackup = strLine.Trim().Replace("main", "static void Main") + "\n";
                strBackup = strBackup.Replace("()", "(string[] args)");
                strBackup = strBackup.Replace("(int argc, char *argv)", "(string[] args)");

                // if it contains {, remove {, and then put sub line 
                if (strLine.Trim().Contains("{"))
                {
                    iLen = strBackup.Trim().IndexOf("{");
                    strBackup = strBackup.Remove(iLen);
                    rTxtCs.Text += strBackup + "\n" + "\t{\n";
                }
                else 
                {
                    rTxtCs.Text += strBackup;
                }

                return false;
            }

            // put other lines without changing 
            if (strLine.Trim().Contains("main(") == false)
            {
                rTxtCs.Text += "\t" + strLine + "\n";
                return false;
            }

            return true;
        }

        /***************************************************************************** 
            Purpose: Convert Cpp To CSharp Function ... 
            Inputs:  Rich Text Bor for Cpp Code
            Returns: Converted Cpp Code as CSharp
        *****************************************************************************/
        private RichTextBox ConvertToCSharp(RichTextBox rTxtCpp)
        {
            /* Check commands line */
            bool bAccept = false;

            /* ------ read step by step with line ------- */
            for (int i = 0; i < rTxtCpp.Lines.Length; i++)
            {
                // Convert blank line 
                if (rTxtCpp.Lines[i].Trim() == "")
                {
                    rTxtCs.Text += rTxtCpp.Lines[i].Trim() + "\n";
                }
                // Convert // commands  
                else if (rTxtCpp.Lines[i].Trim().StartsWith("//") == true)
                {
                    rTxtCs.Text += rTxtCpp.Lines[i] + "\n";
                }
                // Convert /* */ commands
                else if (rTxtCpp.Lines[i].Trim().StartsWith("/*") == true && rTxtCpp.Lines[i].Trim().Contains("*/") == false)
                {
                    rTxtCs.Text += rTxtCpp.Lines[i] + "\n";
                    bAccept = true;
                }
                // Convert /* */ commands
                else if (rTxtCpp.Lines[i].Trim().StartsWith("/*") == true && rTxtCpp.Lines[i].Trim().Contains("*/") == true)
                {
                    rTxtCs.Text += rTxtCpp.Lines[i] + "\n";
                }
                // Convert /* */ commands with checking bAccept Value
                else if (bAccept == true && rTxtCpp.Lines[i].Trim().Contains("*/") == false)
                {
                    rTxtCs.Text += rTxtCpp.Lines[i] + "\n";
                    bAccept = true;
                }
                // Convert /* */ commands with checking bAccept Value
                else if (bAccept == true && rTxtCpp.Lines[i].Trim().Contains("*/") == true)
                {  
                    rTxtCs.Text += rTxtCpp.Lines[i].Trim() + "\n";
                    bAccept = false;
                }
                // Convert Library, Class, Main code
                else
                {
                    // if bLibary is false, convert bLibrary codes 
                    if (bLibrary == false)
                    {
                        bLibrary = codeLibrary(rTxtCpp.Lines[i]);
                        if (bLibrary == true) bClass = false;
                    }

                    // if bClass is false, convert bClass codes
                    if (bClass == false)
                    {
                        bClass = codeClass(rTxtCpp.Lines[i]);
                        if (bClass == true) bMain = false;
                    }

                    // if bMain is false, convert bMain codes
                    if (bMain == false)
                    {
                        bMain = codeMain(rTxtCpp.Lines[i]);
                    }
                }
            }

            // last of code, add \n} ... Because at c++ we had removed };
            if (iOpenCloseParNum == 1)
            {
                rTxtCs.Text += "\n}";
            }

            return rTxtCs;
        }

        /***************************************************************************** 
            Purpose: Save Converted Cpp File. Save as Csharp
            Inputs:  Save File Dialog Parameter
            Returns: Return value nothing.
        *****************************************************************************/
        private void btnSaveFileCSharp_Click(object sender, EventArgs e)
        {
            Stream myStream;

            saveFileCSharp.Filter = "C# Files (*.cs)|*.cs|Header Files (*.h)|*.h";
            saveFileCSharp.FileName = strSaveFileName;
            saveFileCSharp.RestoreDirectory = true;

            if (saveFileCSharp.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileCSharp.OpenFile()) != null)
                {
                    StreamWriter wText = new StreamWriter(myStream);

                    wText.Write(rTxtCSharpCode.Text);

                    myStream.Close();
                }
            }

        }

        /***************************************************************************** 
            Purpose: if user convert new code again, clean and initialize all variables
            Inputs:  button parameters
            Returns: Return value nothing.
        *****************************************************************************/
        private void btnClear_Click(object sender, EventArgs e)
        {
            rTxtCppCode.Text = "";
            rTxtCSharpCode.Text = "";
            rTxtCppCode.Text = "";
            rTxtCs.Text = "";

            /* -- Convert Cpp To CSharp --*/
            strSaveFileName = "";
            className = "Undeclared";
            bLibrary = false;
            bClass = true;
            bMain = true;
            bUsingSystem = false;
            bPublicPrefix = false;
            bPrivatePrefix = false;
            bProtectedPrefix = false;
            strPrefix = "";
            iOpenCloseParNum = 0;
        }
    }
}