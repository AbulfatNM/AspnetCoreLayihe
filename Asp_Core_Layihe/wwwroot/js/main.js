(function ($) {
    //Subscribe Emil start
    $(document).on('click', '#Subscribe_button', function () {
        let email = $('#Subscribe-email').val().trim();
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
  
    //Teacher serach strart
    $("#teacherSearch").keyup(function () {
        let search = $(this).val();
        $("#search-form li").remove()
        if (search.length >= 2) {
            $.ajax({
                url: "/Teacher/TeacherSerach?search=" + search,
                type: "Get",
                success: function (res) {
                    $("#search-form").append(res)
                }
            })
        }
    })
        //Teacher serach end
    //Blog search start
    $("#BlogSearch").keyup(function () {
        let searchBlog = $(this).val();
        $("#Blog-form li").remove()
        if (searchBlog.length >= 2) {
            $.ajax({
                url: "/Blog/BlogSearch?search=" + searchBlog,
                type: "Get",
                success: function (res) {
                    $("#Blog-form").append(res)
                }
            })
        }
    })
 
    //Blog search end
    //Event search start
    $("#EventSearch").keyup(function () {
        let searchBlog = $(this).val();
        $("#Event-form li").remove()
        if (searchBlog.length >= 2) {
            $.ajax({
                url: "/Event/EventSearch?search=" + searchBlog,
                type: "Get",
                success: function (res) {
                    $("#Event-form").append(res)
                }
            })
        }
    })

    //Event search end
"use strict";  
    
/*------------------------------------
	Sticky Menu 
--------------------------------------*/
 var windows = $(window);
    var stick = $(".header-sticky");
	windows.on('scroll',function() {    
		var scroll = windows.scrollTop();
		if (scroll < 5) {
			stick.removeClass("sticky");
		}else{
			stick.addClass("sticky");
		}
	});  
/*------------------------------------
	jQuery MeanMenu 
--------------------------------------*/
	$('.main-menu nav').meanmenu({
		meanScreenWidth: "767",
		meanMenuContainer: '.mobile-menu'
	});
    
    
    /* last  2 li child add class */
    $('ul.menu>li').slice(-2).addClass('last-elements');
/*------------------------------------
	Owl Carousel
--------------------------------------*/
    $('.slider-owl').owlCarousel({
        loop:true,
        nav:true,
        animateOut: 'fadeOut',
        animateIn: 'fadeIn',
        smartSpeed: 2500,
        navText:['<i class="fa fa-angle-left"></i>','<i class="fa fa-angle-right"></i>'],
        responsive:{
            0:{
                items:1
            },
            768:{
                items:1
            },
            1000:{
                items:1
            }
        }
    });

    $('.partner-owl').owlCarousel({
        loop:true,
        nav:true,
        navText:['<i class="fa fa-angle-left"></i>','<i class="fa fa-angle-right"></i>'],
        responsive:{
            0:{
                items:1
            },
            768:{
                items:3
            },
            1000:{
                items:5
            }
        }
    });  

    $('.testimonial-owl').owlCarousel({
        loop:true,
        nav:true,
        navText:['<i class="fa fa-angle-left"></i>','<i class="fa fa-angle-right"></i>'],
        responsive:{
            0:{
                items:1
            },
            768:{
                items:1
            },
            1000:{
                items:1
            }
        }
    });
/*------------------------------------
	Video Player
--------------------------------------*/
    $('.video-popup').magnificPopup({
        type: 'iframe',
        mainClass: 'mfp-fade',
        removalDelay: 160,
        preloader: false,
        zoom: {
            enabled: true,
        }
    });
    
    $('.image-popup').magnificPopup({
        type: 'image',
        gallery:{
            enabled:true
        }
    }); 
/*----------------------------
    Wow js active
------------------------------ */
    new WOW().init();
/*------------------------------------
	Scrollup
--------------------------------------*/
    $.scrollUp({
        scrollText: '<i class="fa fa-angle-up"></i>',
        easingType: 'linear',
        scrollSpeed: 900,
        animation: 'fade'
    });
/*------------------------------------
	Nicescroll
--------------------------------------*/
     $('body').scrollspy({ 
            target: '.navbar-collapse',
            offset: 95
        });
$(".notice-left").niceScroll({
            cursorcolor: "#EC1C23",
            cursorborder: "0px solid #fff",
            autohidemode: false,
            
        });

})(jQuery);	