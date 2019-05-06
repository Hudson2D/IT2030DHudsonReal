function searchFailed() {
    $("#searchresults").html("No Events Found");

}




function random() {
    document.write(Math.floor(Math.random() * 9999) + 1);

}







$(function () {
    $(".RemoveLink").click(function () {
        var id = $(this).attr("data-id");

        $.post("/ShoppingCart/RemoveFromCart", { "id": id }, function (data) {
            $("#update-message").text(data.Message);
            $("#item-count-" + data.DeleteId).text(data.ItemCount);
            $("#item-status-" + data.DeleteId).text(data.OrderMessage);


//         if (data.ItemCount < 1) {
 //           $("#record-" + data.DeleteId).fadeOut();
 //           }

            if (data.ItemCount < 1) {
                $("#RemoveLink").fadeOut();
                $("#RemoveLink").hide();
                
            }
        });

    })
});


