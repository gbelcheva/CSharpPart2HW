/* Task Description */
/* 
	Create a function constructor for Person. Each Person must have:
	*	properties `firstname`, `lastname` and `age`
		*	firstname and lastname must always be strings between 3 and 20 characters, containing only Latin letters
		*	age must always be a number in the range 0 150
			*	the setter of age can receive a convertible-to-number value
		*	if any of the above is not met, throw Error 		
	*	property `fullname`
		*	the getter returns a string in the format 'FIRST_NAME LAST_NAME'
		*	the setter receives a string is the format 'FIRST_NAME LAST_NAME'
			*	it must parse it and set `firstname` and `lastname`
	*	method `introduce()` that returns a string in the format 'Hello! My name is FULL_NAME and I am AGE-years-old'
	*	all methods and properties must be attached to the prototype of the Person
	*	all methods and property setters must return this, if they are not supposed to return other value
		*	enables method-chaining
*/
function solve() {
	function validateName(name){
		if ( 3 < name.length && name.length < 20 && /^[a-zA-Z]+$/.test(name) && typeof name === 'string') {
			return true;
		}
		return false;
	}

	function validateAge(age){
		if ( 0 <= age && age <= 150) {
			return true;
		}
		return false;
	}

	var Person = (function () {
		function Person(firstname, lastname, age) {
			this.firstname = firstname;
			this.lastname = lastname;
			this.age = age;
		}

		Object.defineProperty(Person.prototype, 'firstname', {
			get: function () {
				return this._firstname;
			},
			set: function (value) {
				if (!validateName(value)) {
					throw new Error('First name is invalid');
				}
				this._firstname = value;
			}
		});

		Object.defineProperty(Person.prototype, 'lastname', {
			get: function () {
				return this._lastname;
			},
			set: function (value) {
				if (!validateName(value)) {
					throw new Error('Last name is invalid');
				}
				this._lastname = value;
			}
		});

		Object.defineProperty(Person.prototype, 'age', {
			get: function () {
				return this._age;
			},
			set: function (value) {
				if (!validateAge(Number(value))) {
					throw new Error('Age is invalid');
				}
				this._age = Number(value);
			}
		});

		Object.defineProperty(Person.prototype, 'fullname', {
			get: function () {
				return this.firstname + ' ' + this.lastname;
			},
			set: function (value) {
				this.firstname = value.split(' ')[0];
				this.lastname = value.split(' ')[1];
			}
		});

		Person.prototype.introduce = function() {
				return 'Hello! My name is ' + this.fullname + ' and I am ' + this._age + '-years-old';
		};

		return Person;
	} ());

	return Person;
}
module.exports = solve;