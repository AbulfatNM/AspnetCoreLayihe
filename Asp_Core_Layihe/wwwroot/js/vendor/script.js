$(document).ready(function () {
    //Subscribe Emil start
    $(document).on('click', '#Subscribe_button', function () {
        let email = $('#Subscribe-email').val().trim();
        console.log(email);
        if (email) {
            $.ajax({
                url: "/Subscribe/SubscribeEmail?email=" + email,
                type: "Post",
                success: function (res) {
                    swal(`${res}`);
                },
                error: function () {
                    swal("An error occurred !", {
                        icon: "error",
                    });
                }
            })

        }
    })
})
        //Subscribe Emil end