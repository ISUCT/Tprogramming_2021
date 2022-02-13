"use strict";
let listBtn = document.querySelector(".list-btn");
function toggleMenuBtn(x) {
    x.classList.toggle("change");
    if (listBtn === null || listBtn === void 0 ? void 0 : listBtn.classList.contains("hidden")) {
        listBtn.classList.replace("hidden", "flex");
    }
    else {
        listBtn === null || listBtn === void 0 ? void 0 : listBtn.classList.replace("flex", "hidden");
    }
}
//# sourceMappingURL=app.js.map