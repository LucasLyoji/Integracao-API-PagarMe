!function(e){var t={};function n(o){if(t[o])return t[o].exports;var r=t[o]={i:o,l:!1,exports:{}};return e[o].call(r.exports,r,r.exports,n),r.l=!0,r.exports}n.m=e,n.c=t,n.d=function(e,t,o){n.o(e,t)||Object.defineProperty(e,t,{configurable:!1,enumerable:!0,get:o})},n.r=function(e){Object.defineProperty(e,"__esModule",{value:!0})},n.n=function(e){var t=e&&e.__esModule?function(){return e.default}:function(){return e};return n.d(t,"a",t),t},n.o=function(e,t){return Object.prototype.hasOwnProperty.call(e,t)},n.p="",n(n.s=0)}([function(e,t){$(".terms button").on("click",function(){$(".review").hide(),$(".agreed").show(),$(".complete button").removeAttr("disabled")}),$(".agreed").on("click",function(){$(".review").show(),$(".agreed").hide(),$(".complete button").attr("disabled","disabled")}),$("button.remove").on("click",function(){$(this).parent().velocity({translateX:"-800px",opacity:0},{duration:500,complete:function(e){$(e).addClass("deleted")},easing:[.65,-.02,.72,.29]})}),$("#changePrices").on("click",function(){var e=$('<span class="strike"></span>'),t=$(".price").first(),n=(t.text(),$('<span class="old"></span>')),o=$('<span class="new">$0.99</span>');t.prepend(e),t.wrapInner(n),n=t.find(".old"),t.append(o),e.velocity({width:"105%"},{duration:500,easing:[1,0,1,1]}),n.velocity({translateY:"-1.2em",opacity:0},{delay:500,duration:800,complete:function(e){$(e).remove()},easing:[0,1,1,1]}),o.velocity({opacity:1},{delay:500,duration:250,easing:"linear",complete:function(e){$(e).contents().unwrap()}})}),$("#undelete").on("click",function(){$(".product.ux-card").each(function(e,t){$(t).hasClass("deleted")&&$(t).velocity("reverse").removeClass("deleted")})})}]);