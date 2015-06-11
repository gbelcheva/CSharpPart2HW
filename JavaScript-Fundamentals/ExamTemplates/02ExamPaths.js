function solve(params) {
    'use strict';
    var paramsTmp = params.slice(),
        i,
        lenI,
        j,
        lenJ;
    var
        rows = (paramsTmp[0] + '').split(' ')[0] * 1,
        cols = (paramsTmp[0] + '').split(' ')[1] * 1,
        inputMatrix = [[]];
    for (i = 0, lenI = rows; i < lenI; i += 1) {
        var tmp = (paramsTmp[i + 1] + '').split(' ');
        inputMatrix[i] = [];
        for (j = 0, lenJ = cols; j < lenJ; j += 1) {
            inputMatrix[i][j] = tmp[j];
        }
    }
    var numberMatrix = [[]], row , col ;
    var power = 1;
    for(row = 0; row < rows; row += 1) {

        numberMatrix[row] = [];

        for ( col = 0; col < cols; col += 1){

            numberMatrix[row][col] = power + col;

        }
        power *= 2;
    }

    var initialI = 0,
        initialJ = 0;
    var
        sum = numberMatrix[initialI][initialJ];
    while (true) {
        switch (inputMatrix[initialI][initialJ]) {
            case 'ur':
                inputMatrix[initialI][initialJ] = 'visited';
                initialI = initialI - 1;
                initialJ = initialJ + 1;
                break;
            case 'ul':
                inputMatrix[initialI][initialJ] = 'visited';
                initialI = initialI - 1;
                initialJ = initialJ - 1;
                break;
            case 'dl':
                inputMatrix[initialI][initialJ] = 'visited';
                initialI = initialI + 1;
                initialJ = initialJ - 1;
                break;
            case 'dr':
                inputMatrix[initialI][initialJ] = 'visited';
                initialI = initialI + 1;
                initialJ = initialJ + 1;
                break;
            case 'visited': return 'failed at (' + initialI + ', ' + initialJ + ')';
            default:
                break;
        }
        if ((initialI >= rows) || (initialI < 0)  || (initialJ >= cols) || (initialJ < 0)) {
            return 'successed with ' + sum;
        }
        sum += numberMatrix[initialI][initialJ];
    }
    return '';
}

var test1 = [
        '3 5',
        'dr dl dr ur ul',
        'dr dr ul ur ur',
        'dl dr ur dl ur'
    ];

var test2 = [];

console.log(solve(test1));

console.log('-------------------------')

console.log(solve(test2));