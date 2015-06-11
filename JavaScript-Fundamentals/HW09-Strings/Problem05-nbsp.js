//Problem 5. nbsp
//
//Write a function that replaces non breaking white-spaces in a text with &nbsp;

var text = 'We are living in an yellow submarine. We don\'t have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.' + String.fromCharCode(160);

function replaceNBSP(text){
    while(text.indexOf(' ') > -1){
        text = text.replace(' ', '&nbsp');
    }
    return text;
}

console.log(replaceNBSP(text));
