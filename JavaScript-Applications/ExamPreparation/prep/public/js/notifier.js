export default {
    success: function(message){
        alert(message);
    },
    error: function(err){
        alert('Error: ' + err);
        console.log(err);
    }
}