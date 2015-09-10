export default {
    validatePassword: function(text, min, max){
        var promi = new Promise(function(resolve, reject){
            if (min <= text.length && text.length <= max) {
                resolve('OK')
            } else {
              reject('password must be between ' + min + ' and ' + max + ' symbols');
            }
        });

        return promi;
    }
}