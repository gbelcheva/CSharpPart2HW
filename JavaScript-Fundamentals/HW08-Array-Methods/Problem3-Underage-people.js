//Problem 3. Underage people
//
//Write a function that prints all underaged persons of an array of person
//Use Array#filter and Array#forEach
//Use only array methods and no regular loops (for, while)

var people,
    underagedPeople;

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
    new Person('Shailene', 'Woodley', 18, true),
];

function underagedPerson(person) {
    return person.age <= 18;
}

underagedPeople = people.filter(underagedPerson);

console.log(underagedPeople);