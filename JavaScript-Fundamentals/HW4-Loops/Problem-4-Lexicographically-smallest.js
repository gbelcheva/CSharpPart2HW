//Problem 4. Lexicographically smallest
//
//Write a script that finds the lexicographically smallest and largest property in document, window and navigator objects.

var d = document,
    w = window,
    n = navigator,
    minD = '}',
    maxD = '!',
    minW = '}',
    maxW = '!',
    minN = '}',
    maxN = '!';


for (var property in d) {
    if (property.toLowerCase() < minD.toLowerCase()) {
        minD = property;
    }
    if (property.toLowerCase() > maxD.toLowerCase()) {
        maxD = property;
    }
}
console.log('document:');
console.log('min = ' + minD);
console.log('max = ' + maxD);


for (var property in w) {
    if (property.toLowerCase() < minW.toLowerCase()) {
        minW = property;
    }
    if (property.toLowerCase() > maxW.toLowerCase()) {
        maxW = property;
    }
}
console.log('window:');
console.log('min = ' + minW);
console.log('max = ' + maxW);


for (var property in n) {
    if (property.toLowerCase() < minN.toLowerCase()) {
        minN = property;
    }
    if (property.toLowerCase() > maxN.toLowerCase()) {
        maxN = property;
    }
}
console.log('navigator:');
console.log('min = ' + minN);
console.log('max = ' + maxN);



