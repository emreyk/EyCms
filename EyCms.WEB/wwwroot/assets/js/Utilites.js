function Notify(msg,type) {
 

    toastr[type](msg,"", {
        positionClass: "toast-top-center",
        closeButton: true,

    });
}