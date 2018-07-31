function gettext(value) {
    return '<div><input type="text" name="name" value="" placeholder="اسم الطالب"class="form-control text-right"   text-right"/><input type= "button" value= "حذف مشارك"onclick="removetext(this)" class="btn btn-primary btn-sm" ></div>'
}
function addtext() {
    var div = document.createElement('DIV');
    div.innerHTML = gettext("");
    document.getElementById("divcont").appendChild(div);
}
function removetext(div) {
    document.getElementById("divcont").removeChild(div.parentNode.parentNode);
}