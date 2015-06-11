function solve(params) {

    var values = (params[0] + '').split(' ');

}

var test1 = [];

var test2 = [];

console.log(solve(test1));

console.log('-------------------------')

console.log(solve(test2));


//sort numbers=======================================================


array.sort(function(a, b) {return a - b});

//check if number====================================================

function isNumber(n) {
    return !isNaN(parseFloat(n)) && Number.isFinite(n);
}

//fill matrix============================================================

var matrix = [[]], rows = 5, cols = 5 ,row , col ;

for(row = 0; row < rows; row += 1) {

    matrix[row] = [];

    for ( col = 0; col < cols; col += 1){

        matrix[row][col] = 0;

    }
}

//while
var i = 0;
while (i<10)
{
    i+=1;
}

//remove '' from array===================================================



array = array.filter(function(item){return !!item;})

// OR

array = array.filter(Boolean);


//zero test

function solve(params){

    console.log(params);

}



