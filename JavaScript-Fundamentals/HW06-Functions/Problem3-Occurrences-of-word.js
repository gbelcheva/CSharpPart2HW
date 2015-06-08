//Problem 3. Occurrences of word
//
//Write a function that finds all the occurrences of word in a text.
//    The search can be case sensitive or case insensitive.
//    Use function overloading.


var text = 'Occurrences of word\n' +
        'Write a function that finds all the occurrences of word in a text.\n' +
        'The search can be case sensitive or case insensitive.\n' +
        'Use function overloading.',
    word = 'Occurrences';

console.log(word + ' --> ' + findOccurencesOfWord(text, word, true));

function findOccurencesOfWord(text, word, caseSensitive) {
    var count = 0,
        words = text.split(/[\s\.,-\/#!$%\^&\*;:{}=\-_`~()]+/).filter(Boolean);
    if (!caseSensitive) {
        for (var w of words) {
            if (w.toLowerCase() === word.toLowerCase()) {
                count += 1 ;
            }
        }
    }
    else {
        for (var w of words) {
            if (w === word) {
                count += 1 ;
            }
        }
    }
    return count;
}




//var text = 'Occurrences of word\n'+
//        'Write a function that finds all the occurrences of word in a text.\n'+
//        'The search can be case sensitive or case insensitive.\n'+
//        'Use function overloading.',
//    wordsOccur = findOccurencesOfWord(text, false);
//
//for (var key in wordsOccur) {
//    console.log(key + ' --> ' + wordsOccur[key]);
//}

//
//function findOccurencesOfWord(text, caseSensitive) {
//    var wordOccurences = {},
//        words = text.split(/[\s\.,-\/#!$%\^&\*;:{}=\-_`~()]+/).filter(Boolean);
//    if (!caseSensitive) {
//        text = text.toLowerCase();
//        words = text.split(/[\s\.,-\/#!$%\^&\*;:{}=\-_`~()]+/).filter(Boolean);
//    }
//    for (var word of words) {
//        if (Object.prototype.hasOwnProperty.call(wordOccurences, word)) {
//            wordOccurences[word] += 1 ;
//        }
//        else {
//            wordOccurences[word] = 1 ;
//        }
//    }
//return wordOccurences;
//}