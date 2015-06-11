function solve(params) {

    var i,
        j,
        k,
        lenI,
        lenJ,
        lenK,
        v1 = 3,
        v2 = 4,
        v3 = 10,
        s = params * 1,
        count = 0;

    for (i = 0, lenI = s / v1; i <= lenI; i += 1) {
        for (j = 0, lenJ = s / v2; j <= lenJ; j += 1) {
            for (k = 0, lenK = s / v3; k <= lenK; k += 1) {
                if (i * 3 + j * 4 + k * 10 === s) {
                    count += 1;
                }
            }
        }
    }
return count;
}

var test1 = '10';

var test2 = [];

console.log(solve(test1));

console.log('\n___________________________________________________________________\n')

console.log(solve(test2));

