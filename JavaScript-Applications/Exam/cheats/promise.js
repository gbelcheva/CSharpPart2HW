//var promise = new Promise(function (resolve, reject) {
//    var workSuccessful = true;
//
//    if (workSuccessful) {
//        resolve('Success!');
//    } else {
//        reject(Error('Failure!'));
//    }
//});
//
//promise.then(function (res) {
//    console.log(res);
//    return res + ' (second pass)'
//}, function (err) {
//    console.log(err);
//}).then(function (res) {
//    console.log(res);
//});

var param = 'input param';

setTimeout(function(){
    function start(param){
        console.log(param);
    }
    start(param);
    console.log('timeout test');
}, 2000, param);