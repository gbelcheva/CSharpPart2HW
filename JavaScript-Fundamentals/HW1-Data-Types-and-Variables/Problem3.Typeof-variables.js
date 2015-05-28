//Problem 3. Typeof variables
//
//Try typeof on all variables you created.

var intLiteral = 123,
    floatLiteral = 12.3,
    stringLiteral = '123',
    arrLiteral = [1, 2, 3],
    boolLiteral = true,
    nullLiteral = null,
    undefinedLiteral = undefined,
    objectLiteral = {colour: 'yellow', shape: 'sphere', dimension: 2},
    functionLiteral = function () {
        return 0;
    };

var literals = [intLiteral, floatLiteral, stringLiteral, arrLiteral, boolLiteral, objectLiteral, functionLiteral];

for (var index in literals) {
    console.log('type: ' + typeof literals[index] + ' -> ' + literals[index] );
}