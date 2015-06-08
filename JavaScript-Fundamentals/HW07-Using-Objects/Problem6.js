//Problem 6.
//
//Write a function that groups an array of people by age, first or last name.
//    The function must return an associative array, with keys - the groups, and values - arrays with people in this groups
//
//Use function overloading (i.e. just one function)
//
//Example:
//
//    var people = {…};
//var groupedByFname = group(people, 'firstname');
//var groupedByAge= group(people, 'age');
//

var groupedByFname,
    groupedByAge,
    people = [
        {firstname: 'Gosho', lastname: 'Petrov', age: 32},
        {firstname: 'Bay', lastname: 'Ivan', age: 81},
        {firstname: 'Gosho', lastname: 'of Cambridge', age: 1},
        {firstname: 'Amerigo', lastname: 'Vespucci', age: 561},
        {firstname: 'Miranda', lastname: 'Kerr', age: 32}];

function group(array, key) {
    var grouped = {},
        tmpKey;
    for (var element of array)
    {
        tmpKey = element[key];
        if (Object.prototype.hasOwnProperty.call(grouped, tmpKey)) {
            grouped[tmpKey].push(element);
        }
        else {
            grouped[tmpKey] = [element];
        }
    }
    return grouped;
}

groupedByFname = group(people, 'firstname');
groupedByAge = group(people, 'age');
console.log('Grouped by first name:');
console.log(groupedByFname);
console.log('Grouped by age:');
console.log(groupedByAge);