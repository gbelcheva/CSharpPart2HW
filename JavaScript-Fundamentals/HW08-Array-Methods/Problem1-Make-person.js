//Problem 1. Make person
//
//Write a function for creating persons.
//    Each person must have firstname, lastname, age and gender (true is female, false is male)
//Generate an array with ten person with different names, ages and genders


var people = Array.apply(null, generatePeople(8));

function Person(firstname, lastname, age, gender) {
    this.firstname = firstname;
    this.lastname = lastname;
    this.age = age;
    this.gender = gender;
}

function generatePeople(numberOfPeople) {
    var i,
        firstname = '',
        lastname = '',
        age = 0,
        gender = false,
        people = [];
    for (i = 0; i < numberOfPeople; i += 1) {
        var j,
            k,
            len;
        for (j = 0, len = Math.random() * 10 | 0; j < len; j += 1) {
            firstname += String.fromCharCode(96 + ((Math.random() * 100 / 4 + 1) | 0));
        }
        for (k = 0, len = Math.random() * 10 | 0; k < len; k += 1) {
            lastname += String.fromCharCode(96 + ((Math.random() * 100 / 4 + 1) | 0));
        }
        age = (Math.random() * 100 / 1.18) | 0 + 1;
        gender = Math.random() > 0.5 ? true : false;
        people.push(
            new Person(
                firstname.charAt(0).toUpperCase() + firstname.slice(1),
                lastname.charAt(0).toUpperCase() + lastname.slice(1),
                age,
                gender)
        );
        firstname = '';
        lastname = '';
        age = 0;
        gender = false;
    }
    return people;
}

console.log(people);