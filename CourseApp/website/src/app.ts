
let listBtn = document.querySelector(".list-btn");

function toggleMenuBtn(x: any) {
    x.classList.toggle("change");
    if(listBtn?.classList.contains("hidden")){
        listBtn.classList.replace("hidden", "flex");
    }
    else{
        listBtn?.classList.replace("flex", "hidden");
    }
}