//Problem 10. Find palindromes
//
//Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".

text = 'ABBA , sfkdlsfj, sdklflkds dgd g dsfffff lamal exe asdfdsa, aaaa, plko';

function extractPalindromes(text){
   var palindromes = [],
       words = text.split(/[\s\.,-\/#!$%\^&\*;:{}=\-_`~()]+/).filter(Boolean);
    for (var word of words) {
        var firstPart = word.substring(0, word.length / 2 | 0);
        var secondPart = word.substr(-firstPart.length);
        if (firstPart === secondPart.split('').reverse().join('')) {
            palindromes.push(word);
        }
    }
    return palindromes;
}

console.log(extractPalindromes(text));