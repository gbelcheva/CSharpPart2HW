//Problem 2. People of age
//
//Write a function that checks if an array of person contains only people of age (with age 18 or greater)
//Use only array methods and no regular loops (for, while)

var people,
    isSomeoneUndaraged;

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

function isUnderaged(person) {
    if (person.age <= 18) {
        return true;
    }
    return false;
}

isSomeoneUnderaged = people.some(isUnderaged);


console.log(people);
console.log('Is everyone of age? ' + !isSomeoneUnderaged);