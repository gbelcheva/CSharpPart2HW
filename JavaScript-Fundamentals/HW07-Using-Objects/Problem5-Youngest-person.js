//Problem 5. Youngest person
//
//Write a function that finds the youngest person in a given array of people and prints his/hers full name
//
//Each person has properties firstname, lastname and age.
//
//    Example:
//
//var people = [
//    { firstname : 'Gosho', lastname: 'Petrov', age: 32 },
//    { firstname : 'Bay', lastname: 'Ivan', age: 81},… ];
//

var youngest,
    people = [
        {firstname: 'Gosho', lastname: 'Petrov', age: 32},
        {firstname: 'Bay', lastname: 'Ivan', age: 81},
        {firstname: 'Prince George', lastname: 'of Cambridge', age: 1},
        {firstname: 'Amerigo', lastname: 'Vespucci', age: 561}];

function getYoungest(people){
    var youngest = people[0];
    for (var person of people) {
        if (person.age < youngest.age) {
            youngest = person;
        }
    }
    return youngest;
}

youngest = getYoungest(people);

console.log(people);
console.log('Youngest person: ' + youngest.firstname + ' ' + youngest.lastname );
