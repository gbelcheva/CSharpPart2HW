//Problem 4. Average age of females
//
//Write a function that calculates the average age of all females, extracted from an array of persons
//Use Array#filter
//Use only array methods and no regular loops (for, while)


var people,
    averageAgeOfFemales,
    females;

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

function isFemale(person) {
    return person.gender === true;
}

females = people.filter(isFemale);
averageAgeOfFemales = females.reduce(function (sum, female) {
        return sum + female.age;
    }, 0) / females.length;

console.log(averageAgeOfFemales);