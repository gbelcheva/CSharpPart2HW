/* Task Description */
/* 
	Write a function that sums an array of numbers:
		numbers must be always of type Number
		returns `null` if the array is empty
		throws Error if the parameter is not passed (undefined)
		throws if any of the elements is not convertible to Number	

*/

function solve(arr) {
	var i, len,
		sum = 0;
	if (arr === undefined) {
		throw  new Error('yes');
	}
	if (arr.length === 0) {
		return null;
	}
	for (i = 0, len = arr.length; i < len; i += 1) {
		if (isNaN(arr[i])) {
			throw new Error('yes')
		}
		sum += Number(arr[i]);
	}
	return sum;
}

module.exports = solve;