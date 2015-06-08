//Problem 4. Typeof null
//
//Create null, undefined variables and try typeof on them.

var nullLiteral = null,
    undefinedLiteral = undefined;

var literals = [nullLiteral, undefinedLiteral];

for (var index in literals) {
    console.log('type: ' + typeof literals[index] + ' -> ' + literals[index] );
}