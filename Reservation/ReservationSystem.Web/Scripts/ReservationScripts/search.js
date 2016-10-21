$(document).ready(function () {

    $("#SelectRoomDropdown").change(function () {
        var roomToBook = $("#SelectRoomDropdown").val();
        var numberOfClonedClass = $(".clonedClass").length + 1;
        if (numberOfClonedClass > roomToBook) {
            $(".clonedClass").each(function (index) {
                if (index + 2 > roomToBook) {
                    $(this).remove();
                }
            });
            return false
        };

        for (var index = 0; index < roomToBook - numberOfClonedClass; index++) {
            $("#SearchPanel").clone().addClass("clonedClass").appendTo("#reservation");
        }
    });
});