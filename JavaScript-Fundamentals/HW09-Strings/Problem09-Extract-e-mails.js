//Problem 9. Extract e-mails
//
//Write a function for extracting all email addresses from given text.
//    All sub-strings that match the format @… should be recognized as emails.
//    Return the emails as array of strings.

var text = 'sadkghlskfdgldk sdgdsg@sdgd.dkf, fhdfdhs@dsg.com. <dsfg.dsfs@dddd.ccc> (aaaaa@ssss.ccc) (@@@@@@@@)';

function extractEmail(text){
    return text.match(/([a-zA-Z0-9._-]+@[a-zA-Z0-9._-]+\.[a-zA-Z0-9._-]+)/gi);
}

console.log(extractEmail(text));