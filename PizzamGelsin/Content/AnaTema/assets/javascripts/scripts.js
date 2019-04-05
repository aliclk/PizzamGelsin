$(document).ready(function(){
  
   function addItem(form_id) {
	   "use strict"; 
	   
      $.ajax({
        type: 'POST',
        url: '/cart/add.js',
        dataType: 'json',
        data: $('#'+form_id).serialize(),
        success: Shopify.onSuccess,
        error: Shopify.onError
      });
   }
   
   

   Shopify.onSuccess = function() {
	  "use strict"; 
	  
      var elem = $('.addtocart');

      elem.removeAttr("disabled");

      var quantity = parseInt(jQuery('[name="quantity"]').val(), 10) || 1;

      $("html, body").animate({ scrollTop: 0 }, 250, 'swing');

      function animate() {

        $("#cart-animation").show();

        var addtocartWidth = elem.outerWidth() / 2
        var addtocartHeight = elem.outerHeight() / 2

        var addtocartLeft = elem.offset().left + addtocartWidth;
        var addtocartTop = $(elem).offset().top + addtocartHeight ;

        var buttonAreaWidth = $("#cart-target").outerWidth();
        var buttonAreaHeight = $("#cart-target").outerHeight();

        var buttonAreaLeft = ($("#cart-target").offset().left + buttonAreaWidth / 2  - $("#cart-animation").outerWidth() / 2) - 4 - 18;
        var buttonAreaTop = ($("#cart-target").offset().top + buttonAreaWidth / 2  - $("#cart-animation").outerHeight() / 2) - 4 - 8;

        var path = {
          start: {
            x: addtocartLeft,
            y: addtocartTop,
            angle: 190.012,
            length: 0.2
          },
          end: {
            x: buttonAreaLeft,
            y: buttonAreaTop,
            angle: 90.012,
            length: 0.50
          }
        };

        $('#cart-animation').text(quantity).animate(
        {
          path : new $.path.bezier(path)
        },
        1200,
        function() {
          $("#cart-animation").fadeOut(500, function() {
            $(elem).prop("disabled", false)
            var cartCount =  parseInt($('#cart-count').text()) + quantity;
            $('#cart-count').text(cartCount)
            $('#cart-target').addClass('has-items');
          })
        }
        );
      }

      animate();
    };

    Shopify.onError = function(XMLHttpRequest, textStatus) {
      // Shopify returns a description of the error in XMLHttpRequest.responseText.
      // It is JSON.
      // Example: {"description":"The product 'Amelia - Small' is already sold out.","status":500,"message":"Cart Error"}
      var data = eval('(' + XMLHttpRequest.responseText + ')');
      if (!!data.message) {
        alert(data.message + '(' + data.status  + '): ' + data.description);
      } else {
        alert('Error : ' + Shopify.fullMessagesFromErrors(data).join('; ') + '.');
      }

      $('.addtocart').removeAttr("disabled");
    };

    Shopify.fullMessagesFromErrors = function(errors) {
      var fullMessages = [];
      jQuery.each(errors, function(attribute, messages) {
        jQuery.each(messages, function(index, message) {
          fullMessages.push(attribute + ' ' + message);
        });
      });
      return fullMessages;
    };

})

jQuery(window).load(function(){

  if ( $('.slides li').size() > 1 ) {

    $('.flexslider').flexslider({
      animation: "slide",
      slideshow: true,
      animationDuration: 700,
      slideshowSpeed: 6000,
      animation: "fade",
      controlsContainer: ".flex-controls",
      controlNav: false,
      keyboardNav: true
    }).hover(function(){ $('.flex-direction-nav').fadeIn();}, function(){$('.flex-direction-nav').fadeOut();});

  }

  $("select.loc_on_change").change(function(){
  	if($(this).attr("value") == "#") return false;
  	window.location = $(this).attr("value");
  });

});

/*============================*/
/* Update main product image. */
/*============================*/
var switchImage = function(newImageSrc, newImage, mainImageDomEl) {
  // newImageSrc is the path of the new image in the same size as originalImage is sized.
  // newImage is Shopify's object representation of the new image, with various attributes, such as scr, id, position.
  // mainImageDomEl is the passed domElement, which has not yet been manipulated. Let's manipulate it now.
  jQuery(mainImageDomEl).attr('src', newImageSrc);
  
  
  if ($(window).width() > 782) {jQuery(mainImageDomEl).parent().trigger('zoom.destroy').zoom( { url: newImageSrc.replace('_master', '') } );}
  
};


jQuery(document).ready(function($){

  /*$("a.zoom").fb({
    padding:0,
    'titleShow': false,
    overlayColor: '#000000',
    overlayOpacity: 0.2
  });*/

  /* Update main product image when a thumbnail is clicked. */
  /*==========================*/
  $('#product .thumbs a').on('click', function(e) {
    e.preventDefault();
    switchImage($(this).attr('href'), null, $('.featured img')[0]);
  } );
  
  /*$('#product_newsletter .thumbs a').on('click', function(e) {
    e.preventDefault();
    switchImage($(this).attr('href'), null, $('.featured img')[0]);
  } );*/

  
  /* Initialize zoom on main product image */
  var mainProductImage = $('.featured img');
  if (mainProductImage.size()) {
    if ($(window).width() > 782) {
    var zoomedSrc = $('.featured img').attr('src').replace('_master', '');
    $('.featured img')
      .wrap('<span style="display:inline-block; max-width: 100%;"></span>')
      .css('display', 'block')
      .parent()
      .zoom( { url: zoomedSrc } );
	}
  }
  

  $(".flyout").hide();

  $("#menu-toggle").on("click", function() {
    $(".flyout").slideToggle( "fast" );
  });

  $(".sub-menu").hide();
  $(".more").on("click", function() {
    $(this).nextAll("ul").slideToggle( "fast" );
    $("i", this).toggleClass("fa-plus fa-minus");
  });

  $('input[type="submit"], input.btn, button').on('click', function() { // remove ugly outline on input button click
    $(this).blur();
  })

  $("li.dropdown").hover(function(){
    $(this).children('.dropdown').show();
    $(this).children('.dropdown').stop();
    $(this).children('.dropdown').animate({
      opacity: 1.0
    }, 200);
  }, function(){
    $(this).children('.dropdown').stop();
    $(this).children('.dropdown').animate({
      opacity: 0.0
    }, 400, function(){
      $(this).hide();
    });
  });

}); // end document ready

/* jQuery css bezier animation support -- Jonah Fox */

;(function($){

  $.path = {};

  var V = {
    rotate: function(p, degrees) {
      var radians = degrees * Math.PI / 180,
        c = Math.cos(radians),
        s = Math.sin(radians);
      return [c*p[0] - s*p[1], s*p[0] + c*p[1]];
    },
    scale: function(p, n) {
      return [n*p[0], n*p[1]];
    },
    add: function(a, b) {
      return [a[0]+b[0], a[1]+b[1]];
    },
    minus: function(a, b) {
      return [a[0]-b[0], a[1]-b[1]];
    }
  };

  $.path.bezier = function( params, rotate ) {
    params.start = $.extend( {angle: 0, length: 0.3333}, params.start );
    params.end = $.extend( {angle: 0, length: 0.3333}, params.end );

    this.p1 = [params.start.x, params.start.y];
    this.p4 = [params.end.x, params.end.y];

    var v14 = V.minus( this.p4, this.p1 ),
      v12 = V.scale( v14, params.start.length ),
      v41 = V.scale( v14, -1 ),
      v43 = V.scale( v41, params.end.length );

    v12 = V.rotate( v12, params.start.angle );
    this.p2 = V.add( this.p1, v12 );

    v43 = V.rotate(v43, params.end.angle );
    this.p3 = V.add( this.p4, v43 );

    this.f1 = function(t) { return (t*t*t); };
    this.f2 = function(t) { return (3*t*t*(1-t)); };
    this.f3 = function(t) { return (3*t*(1-t)*(1-t)); };
    this.f4 = function(t) { return ((1-t)*(1-t)*(1-t)); };

    /* p from 0 to 1 */
    this.css = function(p) {
      var f1 = this.f1(p), f2 = this.f2(p), f3 = this.f3(p), f4=this.f4(p), css = {};
      if (rotate) {
        css.prevX = this.x;
        css.prevY = this.y;
      }
      css.x = this.x = ( this.p1[0]*f1 + this.p2[0]*f2 +this.p3[0]*f3 + this.p4[0]*f4 +.5 )|0;
      css.y = this.y = ( this.p1[1]*f1 + this.p2[1]*f2 +this.p3[1]*f3 + this.p4[1]*f4 +.5 )|0;
      css.left = css.x + "px";
      css.top = css.y + "px";
      return css;
    };
  };

  $.path.arc = function(params, rotate) {
    for ( var i in params ) {
      this[i] = params[i];
    }

    this.dir = this.dir || 1;

    while ( this.start > this.end && this.dir > 0 ) {
      this.start -= 360;
    }

    while ( this.start < this.end && this.dir < 0 ) {
      this.start += 360;
    }

    this.css = function(p) {
      var a = ( this.start * (p ) + this.end * (1-(p )) ) * Math.PI / 180,
        css = {};

      if (rotate) {
        css.prevX = this.x;
        css.prevY = this.y;
      }
      css.x = this.x = ( Math.sin(a) * this.radius + this.center[0] +.5 )|0;
      css.y = this.y = ( Math.cos(a) * this.radius + this.center[1] +.5 )|0;
      css.left = css.x + "px";
      css.top = css.y + "px";
      return css;
    };
  };

  $.fx.step.path = function(fx) {
    var css = fx.end.css( 1 - fx.pos );
    if ( css.prevX != null ) {
      $.cssHooks.transform.set( fx.elem, "rotate(" + Math.atan2(css.prevY - css.y, css.prevX - css.x) + ")" );
    }
    fx.elem.style.top = css.top;
    fx.elem.style.left = css.left;
  };

})(jQuery);
