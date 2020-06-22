


deleteItem = form => {
    try {
        $.ajax({
            type: 'POST',
            url: form.action,
            success: function (res) {
                if (res.isValid) {
                    $('#view_all_items').html(res.html);

                }
                error: function(err) {
                    console.log(err);
                }
            }
        })
    } catch (e) {
        console.log(e);
    }
    return false;
};

