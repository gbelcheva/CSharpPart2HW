//Problem 6. Extract text from HTML
//
//Write a function that extracts the content of a html page given as text.
//    The function should return anything that is in a tag, without the tags.
//
//    Example:
//
//<html>
//<head>
//<title>Sample site</title>
//</head>
//<body>
//<div>text
//<div>more text</div>
//and more...
//</div>
//in body
//</body>
//</html>
//
//Result: Sample sitetextmore textand more...in body

var text =
    '<html>' +
    '<head>' +
    '<title>Sample site</title>' +
    '</head>' +
    '<body>' +
    '<div>text' +
    '<div>more text</div>' +
    'and more...' +
    '</div>' +
    'in body' +
    '</body>' +
    '</html>';

function extractText(htmlPage){
    var i,
        j,
        len,
        tags = [
            '<',
            '</'
        ];
    for (var tag of tags) {
        while (text.indexOf(tag) > -1) {
            i = text.indexOf(tag);
            var t = text.substr(i, tag.length);
            if (t === tag) {
                for (j = i; i < text.length; j += 1) {
                    var endTag = '>';
                    t = text.substr(j, endTag.length);
                    if (t === endTag) {
                        var portion = text.slice(i, j + endTag.length);
                        text = text.replace(portion, '');
                        break;
                    }
                }
            }
        }
    }
    return text;
}

console.log(extractText(text));