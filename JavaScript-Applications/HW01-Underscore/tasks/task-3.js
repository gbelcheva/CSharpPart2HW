/* 
 Create a function that:
 *   Takes an array of students
 *   Each student has:
 *   `firstName`, `lastName`, `age` and `marks` properties
 *   `marks` is an array of decimal numbers representing the marks
 *   **finds** the student with highest average mark (there will be only one)
 *   **prints** to the console  'FOUND_STUDENT_FULLNAME has an average score of MARK_OF_THE_STUDENT'
 *   fullname is the concatenation of `firstName`, ' ' (empty space) and `lastName`
 *   **Use underscore.js for all operations**
 */

function solve() {
    return function (students) {
        var highestMarkStudent = _.max(students, function (student) {
            student.avg = _.reduce(student.marks, function (memo, mark) {
                    return memo + mark;
                }, 0) / student.marks.length;
            return student.avg;
        });

        console.log(highestMarkStudent.firstName + ' ' + highestMarkStudent.lastName +
        ' has an average score of ' + highestMarkStudent.avg);
    };
}

module.exports = solve;
