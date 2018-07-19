'use strict';

let liArray = document.getElementById("enum").children;

for (var i = 0 ; i < liArray.length; i++) {

    liArray[i].addEventListener('click', function(event) {
        SortList(event.target.innerHTML);
       // over here you can set the content in main div
    });

}

function SortList(text){
    let parts = document.getElementsByClassName("parts")[0].children;
    for (let part of parts) {
       if(part.innerHTML.charAt(0) === text){
           part.setAttribute("style", "color:red; display: inline;");
       }else{
          part.setAttribute("style", "display: none");
       }      
    }
}

function CreateGroupEnum(listEnums){

}

// (function () {
//     let liArray = document.getElementById("temp").children;
//     console.log(liArray.length);
//     let textArray = [];
//     for (let index = 0; index < liArray.length; index++) {
//         textArray.push(liArray[index].innerHTML);        
//     }
//     console.log(textArray);

//     let parts = document.getElementsByClassName("parts")[0].children;
//     for (let part of parts) {
//        if(part.innerHTML.charAt(0) === "A"){
//            console.log(part.innerHTML);
//        }      
//     }

// }());
