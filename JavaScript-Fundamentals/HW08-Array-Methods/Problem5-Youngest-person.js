//Problem 5. Youngest person
//
//Write a function that finds the youngest male person in a given array of people and prints his full name
//Use only array methods and no regular loops (for, while)
//    Use Array#find

var people,
    youngestMale;

function Person(firstname, lastname, age, gender) {
    this.firstname = firstname;
    this.lastname = lastname;
    this.age = age;
    this.gender = gender;
}

people = [
    new Person('Anne', 'Hathaway', 32, true),
    new Person('Donald', 'Trump', 68, false),
    new Person('Vladimir', 'Putin', 62, false),
    new Person('Shailene', 'Woodley', 23, true),
];

youngestMale = people.sort(function (person1, person2) {return person1.age - person2.age}).find(function (person) {return !person.gender;});

console.log(youngestMale.firstname + ' ' + youngestMale.lastname);