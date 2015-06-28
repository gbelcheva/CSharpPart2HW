/* Task description */
/*
 Write a function that finds all the prime numbers in a range
 1) it should return the prime numbers in an array
 2) it must throw an Error if any on the range params is not convertible to `Number`
 3) it must throw an Error if any of the range params is missing
 */

function solve(start, end) {
    if (arguments.length < 2) {
        throw  new Error('yes');
    }
    var startNum = Number(start),
        endNum = Number(end);

    if (startNum === NaN || endNum === NaN) {
        throw  new Error('yes');
    }
    var result = [];
    var i;
    for (i = startNum; i <= endNum; i += 1) {
        if (i === 1 || i === 0) {
            continue;
        }
        var isPrime = true;
        var j, len;
        for (j = 2, len = Math.sqrt(i); j <= len; j += 1) {
            if (i % j === 0) {
                isPrime = false;
                break;
            }
        }
        if (isPrime) {
            result.push(i);
        }
    }
    return result;

}

module.exports = solve;
