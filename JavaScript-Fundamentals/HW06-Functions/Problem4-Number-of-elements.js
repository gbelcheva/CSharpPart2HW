//Problem 4. Number of elements
//
//Write a function to count the number of div elements on the web page

var doc = document;

console.log('divs --> ' + countDivs(doc))

function countDivs(doc) {
    return doc.getElementsByTagName('div').length;
}

//NB: Test the code in a browser by opening the console (F12) and pasting the code.