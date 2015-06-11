function removeTags(text) {
    var wordsBetweenTags='';
    for (var j = 0; j < text.length; j++) {
        var indexStart = text.indexOf('<');
        var indexEnd = text.indexOf('>');
        text = (text.replace(text.substring(indexStart, indexEnd + 1),''));// trii tagovete
    }
    return  text
}

function getTagName(text) {
    var tagName='';
    for (var i = 0; i < text.length; i++) {
        var indexStart = text.indexOf('>');
        var indexEnd = text.indexOf('<');
        tagName = text.substring(indexStart, indexEnd + 1);
    }
    return tagName;
}

function textBetweenTags(text) {
    var textBetweenTags='';
    for (var i = 0; i < text.length; i++) {
        var indexStart = text.indexOf('>');
        var indexEnd = text.indexOf('</');
        textBetweenTags = text.substring(indexStart+1, indexEnd );
    }
    return textBetweenTags;
}

function convertWordUpcaseAndLowcase(text) {
    text=text.split('');
    var word='';
    for (var i =0;i<text.length;i++) {
        if (i%2===0) {
            word+= text[i].toUpperCase();
        }
        else {
            word += text[i];
        }
    }
    return word;
}

function countStringOccuranceInText(text, pattern) { //Broi vsichki savpadenia na tyrsenia string bez znachenie sliato ili ne
    text = text.toLowerCase();
    var count = 0;
    for (var i = 0; i < text.length; i++) {
        text = text.replace(pattern, "*");
        if (text[i] === '*') {
            count++;
        }
    }
    return count;
}
//------------------------------------------------------------------------
var list = '';
for (var i = 0; i != 26; ++i) list += String.fromCharCode(i + 65);
//create charArray from english alphabet
//=========================================================================================


function isLetter(symbol) {
    var asciiCode = symbol.charCodeAt(0);
    if ((asciiCode > 64 && asciiCode < 91) || (asciiCode > 96 && asciiCode < 123)) {
        return true;
    }
    return false;
}

function isDigit(symbol) {
    var asciiCode = symbol.charCodeAt(0);
    if (asciiCode > 47 && asciiCode < 58)  {
        return true;
    }
    return false;
}

function returnDigitsFromString(string) {
    function isDigit(string) {
        var result=isFinite(string);
        return result;
    }
    function keepOnlyDigitsinString(string) {
        var number = '';
        for (var i = 0; i < string.length; i += 1) {
            if (isDigit(string[i])) {
                number += parseInt(string[i], 10);
            }
        }
        number = number.replace(' ', '');
        return number;
    }
    return keepOnlyDigitsinString(string);
}
//=================================================================================
//Matrix of strings
function makeMatrixOfStrings(arrayOfStrings) {
    var matrix = [];
    arrayOfStrings.forEach(function(string) {
        matrix.push(string.toLowerCase().split(''));
    });
    console.log(matrix);
}

//----------------------------------------------------------------------
//Matrix of Numbers in format:  123
456
function createMatrix(string) {
    var rowCol = string[0].split(' ').map(Number);
    var row = rowCol[0];
    var col = rowCol[1];
    var matrix = [];
    var counter = 1;
    for (var i = 0; i < row; i+=1) {
        matrix[i] = [];
        for (var j = 0; j < col; j+=1) {
            matrix[i][j] = counter++;
        }
    }
    return matrix;
}
///////////////////////////////////////////////////////////////////////////
//vrashta true ili false ako edna dvoika ot charove se povtaria v string
//-------------------------------------------------------------------------
function isRepeatedPairTwoChars(string) {
    var numStr = '' + string;
    var existingPairs = { };
    for (var i = 1; i < numStr.length; i++) {
        var pair = numStr.substr(i - 1, 2);
        if (existingPairs[pair]) {
            if (i - existingPairs[pair] >= 2) {
                return true;
            }
        } else {
            existingPairs[pair] = i;
        }
    }
    return false;
}
//---------------------------------------------------------------------