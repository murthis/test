function SearchVisitor() {
    var searchVal = $("#txtVisitorSearch").val();
    $(".trVisitor").each(function (trItem) {
        var val = 0;
        $(this).find("td").each(function () {
            if ($(this).context.innerText.toUpperCase().indexOf(searchVal.toUpperCase()) > -1) {
                val = val + 1;
            }
        });
        if (val > 0) {
            $(this).show();
            return;
        }
        else {
            $(this).hide();
            return;
        }
    });
}