function solve(params) {
    var paramsTmp = params.slice();
    var i, len;
    var keyValuePairsNumber;
    var keyValuePairs = [];
    var viewLinesNumber;
    var viewLines = [];
    for (i = 0, len = Object.keys(params).length; i < len; i += 1) {
        if (i === 0) {
            keyValuePairsNumber = (paramsTmp[i] + '') * 1;
        }
        if (i > 0 && i < i + keyValuePairsNumber) {
            keyValuePairs.push(paramsTmp[i] + '');
        }
        if (i === keyValuePairsNumber + 1) {
            viewLinesNumber = (paramsTmp[i] + '');
        }
        if (i > keyValuePairsNumber + 1 && i < i + keyValuePairsNumber + 1) {
            viewLines.push(paramsTmp[i] + '');
        }
    }

    var result = viewLines.join('\n');
    var toReplace;
    //while (result.indexOf('@section') > - 1) {
    //}
    //while (result.indexOf('@renderSection') > - 1) {
    //}
    //while (result.indexOf('@if') > - 1) {
    //    toReplace = result.match(/@if\s*\(\s*\w*\s*\)/);

    //}
    //while (result.indexOf('@foreach') > - 1) {
    //}




    return toReplace = result.match( new RegExp('@(\\w+\\s*)|(\\w+\\<)', "g"))+'';
}

var test1 = [ '6',
    'title:Telerik Academy',
    'showSubtitle:true',
    'subTitle:Free training',
    'showMarks:false',
    'marks:3,4,5,6',
    'students:Pesho,Gosho,Ivan',
    '42',
    '@section menu {',
    '<ul id="menu">',
    '    <li>Home</li>',
    '    <li>About us</li>',
    '</ul>',
    '}',
    '@section footer {',
    '<footer>',
    '    Copyright Telerik Academy 2014',
    '</footer>',
    '}',
    '<!DOCTYPE html>',
    '<html>',
    '<head>',
    '    <title>Telerik Academy</title>',
    '</head>',
    '<body>',
    '    @renderSection("menu")',
    '',
    '    <h1>@title</h1>',
    '    @if (showSubtitle) {',
    '        <h2>@subTitle</h2>',
    '        <div>@@JustNormalTextWithDoubleKliomba ;)</div>',
    '    }',
    '',
    '    <ul>',
    '        @foreach (var student in students) {',
    '            <li>',
    '                @student ',
    '            </li>',
    '            <li>Multiline @title</li>',
    '        }',
    '    </ul>',
    '    @if (showMarks) {',
    '        <div>',
    '            @marks ',
    '        </div>',
    '    }',
    '',
    '    @renderSection("footer")',
    '</body>',
    '</html>' ];

var test2 = [];

console.log(solve(test1));

console.log('-------------------------')

console.log(solve(test2));