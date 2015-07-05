/* Task Description */
/* 
 * Create a module for a Telerik Academy course
 * The course has a title and presentations
 * Each presentation also has a title
 * There is a homework for each presentation
 * There is a set of students listed for the course
 * Each student has firstname, lastname and an ID
 * IDs must be unique integer numbers which are at least 1
 * Each student can submit a homework for each presentation in the course
 * Create method init
 * Accepts a string - course title
 * Accepts an array of strings - presentation titles
 * Throws if there is an invalid title
 * Titles do not start or end with spaces
 * Titles do not have consecutive spaces
 * Titles have at least one character
 * Throws if there are no presentations
 * Create method addStudent which lists a student for the course
 * Accepts a string in the format 'Firstname Lastname'
 * Throws if any of the names are not valid
 * Names start with an upper case letter
 * All other symbols in the name (if any) are lowercase letters
 * Generates a unique student ID and returns it
 * Create method getAllStudents that returns an array of students in the format:
 * {firstname: 'string', lastname: 'string', id: StudentID}
 * Create method submitHomework
 * Accepts studentID and homeworkID
 * homeworkID 1 is for the first presentation
 * homeworkID 2 is for the second one
 * ...
 * Throws if any of the IDs are invalid
 * Create method pushExamResults
 * Accepts an array of items in the format {StudentID: ..., Score: ...}
 * StudentIDs which are not listed get 0 points
 * Throw if there is an invalid StudentID
 * Throw if same StudentID is given more than once ( he tried to cheat (: )
 * Throw if Score is not a number
 * Create method getTopStudents which returns an array of the top 10 performing students
 * Array must be sorted from best to worst
 * If there are less than 10, return them all
 * The final score that is used to calculate the top performing students is done as follows:
 * 75% of the exam result
 * 25% the submitted homework (count of submitted homeworks / count of all homeworks) for the course
 */

function solve() {
    function validateTitle(title) {
        return /^(?=^\S)(?=.*\S$)(?=.*)(?=^(?:(?!\s{2}).)*$).*$/.test(title);
    }

    function validateName(name) {
        return /^[A-Z][a-z]*$/.test(name);
    }

    function validateID(id, items) {
        return 1 <= id && id <= items.length;
    }

    function validateUniqueID(id, items) {
        var itemIDs = items.map(
            function (item) {
                return item.StudentID;
            }
        );

        return !itemIDs.some(
            function (itemID, index) {
                return itemID === id && itemIDs.indexOf(id) !== index;
            }
        );
    }

    var Course = {
        init: function (title, presentations) {
            this.title = title;
            this.presentations = presentations;
            this._students = [];

            return this;
        },
        get title() {
            return this._title;
        },
        set title(value) {
            if (!validateTitle(value)) {
                throw new Error('Invalid title.');
            }

            this._title = value;
        },
        get presentations() {
            return this._presentations;
        },
        set presentations(value) {
            if (Object.prototype.toString.call(value) !== '[object Array]') {
                throw new Error("Presentations list is not an array");
            }

            if (value.length < 1) {
                throw new Error('Empty presentations list.');
            }

            if (value.some(function (presentation) {
                    return !validateTitle(presentation);
                })) {
                throw new Error("Presentations contain an invalid title.");
            }

            this._presentations = value;
        },
        addStudent: function (name) {
            var firstname = name.split(' ')[0],
                lastname = name.split(' ')[1];

            if (typeof firstname === 'undefined' ||
                typeof lastname === 'undefined' ||
                typeof name.split(' ')[2] !== 'undefined') {
                throw new Error('Student names are invalid.');
            }

            if (typeof name !== 'string') {
                throw new Error('Student name is not a string');
            }

            if (!(validateName(firstname) && validateName(lastname))) {
                throw new Error('Student name is invalid.');
            }

            this._students.push(
                {
                    firstname: firstname,
                    lastname: lastname,
                    id: this._students.length + 1
                }
            );

            return this._students.length;
        },
        getAllStudents: function () {
            return this._students;
        },
        submitHomework: function (studentID, homeworkID) {
            if (!validateID(studentID, this._students)) {
                throw new Error('Invalid student ID.');
            }

            if (!validateID(homeworkID, this._presentations)) {
                throw new Error('Invalid homework ID.');
            }
        },
        pushExamResults: function (results) {
            if (!results.every(
                    function (result) {
                        return result.hasOwnProperty('StudentID') &&
                            result.hasOwnProperty('score');
                    })
            ) {
                throw new Error('Results are not in the correct format.');
            }

            for (var result of results)
            {
                if (!validateID(result.StudentID, this._students)) {
                    throw new Error('Invalid student ID in results.');
                }

                if (!validateUniqueID(result.StudentID, results)) {
                    throw new Error('Results contain duplicate ID.');
                }

                if (typeof result.score !== 'number') {
                    throw new Error('Result score is not a number.');
                }
            }

            for (var student of this._students)
            {
                if (!results.some(function (result) {
                        return student.id === result.StudentID;
                    })) {
                    results.push(
                        {
                            StudentID: student.id,
                            score: 0
                        }
                    );
                }
            }

        },
        getTopStudents: function () {
        }
    };

    return Course;
}

module.exports = solve;