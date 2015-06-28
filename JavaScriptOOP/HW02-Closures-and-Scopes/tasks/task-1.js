/* Task Description */
/* 
 *	Create a module for working with books
 *	The module must provide the following functionalities:
 *	Add a new book to category
 *	Each book has unique title, author and ISBN
 *	It must return the newly created book with assigned ID
 *	If the category is missing, it must be automatically created
 *	List all books
 *	Books are sorted by ID
 *	This can be done by author, by category or all
 *	List all categories
 *	Categories are sorted by ID
 *	Each book/catagory has a unique identifier (ID) that is a number greater than or equal to 1
 *	When adding a book/category, the ID is generated automatically
 *	Add validation everywhere, where possible
 *	Book title and category name must be between 2 and 100 characters, including letters, digits and special characters ('!', ',', '.', etc)
 *	Author is any non-empty string
 *	Unique params are Book title and Book ISBN
 *	Book ISBN is an unique code that contains either 10 or 13 digits
 *	If something is not valid - throw Error
 */

function solve() {
    var library = (function () {
        var books = [];
        var categories = [];

        function listBooks() {
            if (arguments[0] !== undefined) {
                var propName = Object.getOwnPropertyNames(arguments[0])[0];
                var res = [];
                for (var b of books) {
                    if (b[propName] === arguments[0][propName]) {
                        res.push(b);
                    }
                }
                return res;

            }
            books.sort(function (a, b) {return Number(a.ID) - Number(b.ID);});
            return books;
        }

        function addBook(book) {
            if (book.title.length <= 2 || 100 <= book.title.length) {
                throw new Error('title length');
            }
            if (book.author === '') {
                throw new Error('author empty');
            }
            if (book.isbn.match(/^[0-9]+$/) === null) {
                throw new Error('isbn not digits');
            }
            if (book.isbn.length !== 10 && book.isbn.length !== 13) {
                throw new Error('isbn length');
            }
            if (books.some(function (b) {
                    return b.title === book.title ||
                        b.isbn === book.isbn;
                })) {
                throw new Error('already exists');
            }
            book.ID = books.length + 1;
            books.push(book);
            if (!categories.some(function(c){return c === book.category;})) {
                categories.push(book.category);
            }
            return book;
        }

        function listCategories() {
            //categories.sort(function (a, b) {return Number(a.ID) - Number(b.ID);});
            return categories;
        }

        return {
            books: {
                list: listBooks,
                add: addBook
            },
            categories: {
                list: listCategories
            }
        };
    }());
    return library;
}

module.exports = solve;
