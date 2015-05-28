//Problem 2. Quoted text
//
//Create a string variable with quoted text in it.
//    For example: `'How you doin'?', Joey said'.


var singleSingleQuote = '\'How you doin\'?\', Joey said.',
    singleDoubleQuote = '\"How you doin\'?\", Joey said.',
    doubleSingleQuote = "\'How you doin\'?\', Joey said.",
    doubleDoubleQuote = "\"How you doin\'?\", Joey said.";

var  quotedText = [singleSingleQuote, singleDoubleQuote, doubleSingleQuote, doubleDoubleQuote];

for (var index in quotedText) {
    console.log(quotedText[index]);
}