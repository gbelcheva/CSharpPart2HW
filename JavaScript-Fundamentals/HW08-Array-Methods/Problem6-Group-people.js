//Problem 6. Group people
//
//Write a function that groups an array of persons by first letter of first name and returns the groups as a JavaScript Object
//Use Array#reduce
//Use only array methods and no regular loops (for, while)
//
//    Example:
//
//        result = {
//            'a': [{
//                firstname: 'Asen',
//                /* ... */
//            }, {
//                firstname: 'Anakonda',
//                /* ... */
//            }],
//            'j': [{
//                firstname: 'John',
//                /* ... */
//            }]
//        };

var people,
    grouped;

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
    new Person('Antonio', 'Banderas', 54, false)
];

grouped = people.reduce(function (obj, person) {
    var firstLetter = person.firstname[0];
    if (Object.prototype.hasOwnProperty.call(obj, firstLetter)) {
        obj[firstLetter].push(person);
    }
    else {
        obj[firstLetter] = [person];
    }
    return obj;
}, {});

console.log(grouped);