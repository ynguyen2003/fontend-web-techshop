*{
    margin: 0;
    padding: 0;
    box-sizing: border-box;
    font-family:Arial, Helvetica, sans-serif;
}

h1{
    font-size: 50px;
    line-height: 64px;
    color: #222;
}

h2{
    font-size: 46px;
    line-height: 54px;
    color: #222;
}

h4{
    font-size: 20px;
    color: #222;
}

h6{
    font-weight: 700;
    font-size: 12px;
}

p{
    font-size: 18px;
    color: #464b52;
    margin: 15px 0 20px 0;
}

.section-p1{
    padding: 40px 80px;
}

.section-m1{
    margin: 40px 0;
}

button.normal{
    font-size: 14px;
    font-weight: 600;
    padding: 15px 30px;
    color: #000;
    background-color: #fff;
    border-radius: 4px;
    cursor: pointer;
    border: none;
    outline: none;
    transition: 0.2s;
}

button.white{
    font-size: 14px;
    font-weight: 600;
    padding: 11px 18px;
    color: #fff;
    background-color: transparent;
    border-radius: 4px;
    cursor: pointer;
    border: 1px solid #fff;
    outline: none;
    transition: 0.2s;
}

body{
    width: 100%;
}

/* Header Start */
#header{
    display: flex;
    align-items: center;
    justify-content: space-between;
    padding: 20px 80px;
    background: #fff;
    box-shadow: 0 5px 15px rgba(0, 0, 0, 0.06);
}

#navbar{
    display: flex;
    align-items: center;
    justify-content: center;
}

#navbar li{
    list-style: none;
    padding: 0 20px;
    position: relative;
}

#navbar li a{
    text-decoration: none;
    font-size: 16px;
    font-weight: 600;
    color: #1a1a1a;
    transition: 0.3s ease;
}

#navbar li a:hover,
#navbar li a.active{
    color: rgb(20,103,195);
}
#close{
    display: none;
}
#mobile{
    display: none;
    align-items: center;
}

#navbar li a.active::after,
#navbar li a:hover::after{
    content: "";
    width: 30%;
    height: 2px;
    background: rgb(20,103,195);
    position: absolute;
    bottom: -4px;
    left: 20px;
}

/*Home Page*/
#hero{
    background-image: url("/images/bn1.jpg");
    height: 90vh;
    width: 100%;
    background-size: cover;
    background-position: top 25% right 0;
    padding: 0 80px;
    display: flex;
    flex-direction: column;
    align-items: flex-start;
    justify-content: center;
    z-index: 999;
    top: 0;
    left: 0;
    
}

#hero h4{
    padding-bottom: 15px;
}

#hero h1{
    color: rgb(20,103,195);
}

#hero button{
    background-image: url("images/button.png");
    background-color: transparent;
    color: rgb(20,103,195);
    border: 0;
    padding: 14px 80px 14px 64px;
    background-repeat: no-repeat;
    cursor: pointer;
    font-weight: 700;
    font-size: 15px;
}

#feature{
    display: flex;
    align-items: center;
    justify-content: space-between;
    flex-wrap: wrap;

}

#feature .fe-box{
    width: 180px;
    text-align: center;
    padding: 25px 15px;
    box-shadow: 20px 20px 34px rgba(0, 0, 0, 0.03);
    border: 1px solid #cce7d0;
    border-radius: 4px;
    margin: 15px 0;
}

#feature .fe-box:hover{
    box-shadow: 20px 20px 34px rgba(70, 62, 221, 0.1);
}

#feature .fe-box image{
    width: 100%;
    margin-bottom: 10px;
}

#feature .fe-box h6{
    display: inline-block;
    padding: 9px 8px 6px 8px;
    line-height: 1;
    border-radius: 4px;
    color: rgb(20,103,195);
    background-color: #fddde4;
}

#feature .fe-box:nth-child(2) h6{
    background-color: #cdebbc;
}

#feature .fe-box:nth-child(3) h6{
    background-color: #d1e8f2;
}

#feature .fe-box:nth-child(4) h6{
    background-color: #cdd4f8;
}

#feature .fe-box:nth-child(5) h6{
    background-color: #f6dbf6;
}

#feature .fe-box:nth-child(6) h6{
    background-color: #fff2e5;
}

#product1{
    text-align: center;
}

#product1 .proc-container{
    display: flex;
    justify-content: space-between;
    padding-top: 20px;
    flex-wrap: wrap;
    
}

#product1 .proc{
    width: 23%;
    min-width: 250px;
    padding: 10px 12px;
    border: 1px solid #cce7d0;
    border-radius: 25px;
    cursor: pointer;
    box-shadow: 20px 20px 30px rgba(0, 0, 0, 0.02);
    margin: 15px 0;
    transition: 0.2s ease;
    position: relative;
}

#product1 .proc:hover{
    box-shadow: 20px 20px 30px rgba(0, 0, 0, 0.06);
}

#product1 .proc img{
    width: 100%;
    border-radius: 20px;
}

#product1 .proc .des{
    text-align: start;
    padding: 10px 0;
}

#product1 .proc .des span{
    color: #606063;
    font-size: 14px;

}

#product1 .proc .des h5{
    padding-top: 7px;
    color: #1a1a1a;
    font-size: 16px;

}

#product1 .proc .des i{
    font-size: 16px;
    color: rgb(243, 181, 25);
}

#product1 .proc .des h4{
    padding-top: 7px;
    font-size: 16px;
    font-weight: 700;
    color: rgb(20,103,195);

}

#product1 .proc .cart{
    width: 40px;
    height: 40px;
    line-height: 40px;
    border-radius: 50px;
    background-color: #e8f6ea;
    font-weight: 500;
    color: #088178;
    border: 1px solid #cce7d0;
    position: absolute;
    bottom: 15px;
    right: 10px;
    padding-left: 8px;
}

#banner {
    display: flex;
    flex-direction: column;
    justify-content: center;
    align-items: center;
    text-align: center;
    background-image: url("images/banner/bn3.jpg");
    width: 100%;
    height: 40vh;
    background-size: cover;
    background-position: center;
}

#banner h4{
    color: #fff;
    font-size: 14px;
}

#banner h2{
    color: #fff;
    font-size: 40   px;
    padding: 10px 0;
}

#banner h2 span{
    color: #ef3636;
}

#banner button:hover{
    background-color: rgb(20,103,195);
    color: #fff;
}

#sm-banner{
    display: flex;
    justify-content: space-between;
    flex-wrap: wrap;
}

#sm-banner .banner-box{
    display: flex;
    flex-direction: column;
    justify-content: center;
    align-items: flex-start;
    background-image: url("images/banner/bn2-iphone.jpg");
    min-width: 580px;
    height: 50vh;
    background-size: cover;
    background-position: center;
    padding: 30px;
}

#sm-banner .banner-box2{
    background-image: url("images/banner/bn4-watch.jpg");
}

#sm-banner h4{
    color: #fff;
    font-size: 20px;
    font-weight: 300;
}

#sm-banner h2{
    color: #fff;
    font-size: 28px;
    font-weight: 800;
}

#sm-banner span{
    color: #fff;
    font-size: 14px;
    font-weight: 500;
    padding-bottom: 15px;
}

#sm-banner .banner-box:hover button{
    background:rgb(20,103,195);
    border: 1px solid rgb(20,103,195);
}

#banner3{
    display: flex;
    justify-content: space-between;
    flex-wrap: wrap;
    padding: 0 80px;
}

#banner3 .banner-box{
    display: flex;
    flex-direction: column;
    justify-content: center;
    align-items: flex-start;
    background-image: url("images/banner/bn1-iphone.jpg");
    min-width: 30%;
    height: 30vh;
    background-size: cover;
    background-position: center;
    padding: 20px;
    margin-bottom: 20px;
}

#banner3 .banner-box2{
    background-image: url("images/banner/bn5-watch.jpg");
}

#banner3 .banner-box3{
    background-image: url("images/banner/bn6.jpg");
}

#banner3 h2{
    color: #ff8000;
    font-weight: 900;
    font-size: 22px;
}

#banner3 h3{
    color: #fff;
    font-weight: 800;
    font-size: 15px;
}

#newsletter{
    display: flex;
    justify-content: space-between;
    flex-wrap: wrap;
    align-items: center;
    background-position: 20% 30%;
    background-color: #09142a;
}

#newsletter h4{
    font-size: 22px;
    font-weight: 700;
    color: #e8f6ea;
}

#newsletter p{
    font-size: 14px;
    font-weight: 600;
    color: #e8f6ea;
}

#newsletter p span{
    color: #ef3636;
}

#newsletter .form{
    display: flex;
    width: 40%;
}

#newsletter input{
    height: 3.125rem;
    padding: 0 1.25em;
    font-size: 14px;
    width: 100%;
    border: 1px solid transparent;
    border-radius: 4px;
    outline: none;
    border-top-right-radius: 0;
    border-bottom-right-radius: 0;
}

#newsletter button{
    background-color: #1f5fcd;
    color: #fff;
    white-space: nowrap;
    border-top-left-radius: 0;
    border-bottom-left-radius: 0;
}

footer{
    display: flex;
    flex-wrap: wrap;
    justify-content: space-between;
}

footer .col{
    display: flex;
    flex-direction: column;
    align-items: flex-start;
    margin-bottom: 20px; 
}

footer .logo{
    margin-bottom: 30px;
}

footer h4{
    font-size: 16px;
    padding-bottom: 20px;
}

footer p{
    font-size: 15px;
    margin: 0 0 8px 0;
}

footer a{
    font-size: 15px;
    text-decoration: none;
    color: #222;
    margin-bottom: 10px;
}

footer .follow{
    margin-top: 20px;
}

footer .follow i{
    color: #464b52;
    padding-right: 4px;
    cursor: pointer;
}

footer .install .row img{
    border: 1px solid #041e42;
    border-radius: 6px;
}

footer .install img{
    margin: 10px 0 15px 0;
}

footer .follow i:hover,
footer a:hover{
    color: rgb(20,103,195);
}

footer .copyright{
    width: 100%;
    text-align: center;
}
/*Shop Page*/
#page-header{
    background-image: url("images/banner/bn8.png");
    width: 100%;
    height: 60vh;
    background-size: cover;
    display: flex;
    justify-content: center;
    text-align: center;
    flex-direction: column;
    padding: 14px;
}
#page-header h2{
    color: #59daff;
}
#page-header p{
    color: #fff;
}
#pagination{
    text-align: center;
}
#pagination a{
    text-decoration: none;
    background-color: #041e42;
    padding: 15px 20px;
    border-radius: 4px;
    color: #fff;
    font-weight: 600;
}
#pagination a i{
    font-size: 16px;
    font-weight: 600;
}

/*Single Product*/
#prodetail{
    display: flex;
    margin-top: 20px;
    justify-content: space-between;

}
#prodetail .single-pro-image{
    width: 40%;
    margin-right: 50px;
}

.small-img-group{
    display: flex;
    justify-content: space-between;
}

.small-img-col{
    flex-basis: 24%;
    cursor: pointer;
}
#prodetail .single-pro-detail{
    width: 50%;
    padding-top: 30px;
}
#prodetail .single-pro-detail h4{
    padding:40px 0 20px 0;
}
#prodetail .single-pro-detail h2{
    font-size: 26px;
}
#prodetail .single-pro-detail select{
    display: block;
    padding: 5px 10px;
    margin-bottom: 10px;
}
#prodetail .single-pro-detail input{
    width: 50px;
    height: 47px;
    padding-left: 10px;
    font-size: 16px;
    margin-right: 10px;
}
#prodetail .single-pro-detail input:focus{
    outline: none;
}
#prodetail .single-pro-detail button{
    background-color: #041e42;
    color: #fff;

}
#prodetail .single-pro-detail span{
    line-height: 25px;
}
/*Start Medial Query*/
@media (max-width: 799px) {
    .section-p1{
        padding: 40px 40px;
    }
    #navbar {
        display: flex;
        flex-direction: column;
        align-items: flex-start;
        justify-content: flex-start;
        position: fixed;
        top: 0;
        right: -300px;
        height: 100vh;
        width: 300px;
        background-color: #e3e6f3;
        box-shadow: 0 40px 60px rgba(0, 0, 0, 0.1);
        padding: 80px 0 0 10px;
    }
    #navbar.active{
        right: 0px;

    }
    #navbar li{
        margin-bottom: 25px;
    }
    #mobile{
        display: flex;
        align-items: center;
    }
    #mobile i{
        color: #1a1a1a;
        font-size: 24px;
        padding-left: 20px;
    }
    #close{
        display: initial;
        position: absolute;
        top: 30px;
        left: 30px;
        color: #222;
        font-size: 24px;
    }
    #lg-bag{
        display: none;
    }
    #hero {
        height: 70vh;
        padding: 0 80px;
        background-position: top 30% right 30%;
    }
    #feature{
        justify-content: center;
    }
    #feature .fe-box{
        margin: 15px 15px;

    }
    #product1 .proc-container{
        justify-content: center;
    }
    #product1 .proc{
        margin: 15px;  
    }
    #banner{
        height: 20vh;
    }
    #sm-banner .banner-box{
        min-width: 100%;
        height: 30vh;
    }
    #banner3{
        padding: 0 40px;
    }
    #banner3 .banner-box{
        width: 28%;
    }
    #newsletter .form{
        width: 70%;
    }
}
@media (max-width:477px) {
    .section-p1{
        padding: 20px;
    }
    #header{
        padding: 10px 30px;
    }
    h1{
        font-size: 38px;
    }
    h2{
        font-size: 32px;
    }
    #hero{
        padding: 0 20px;
        background-position: 55%;
    }
    #feature{
        justify-content: space-between;
    }
    #feateru .fe-box{
        width: 155px;
        margin: 0 0 15px 0;
    }
    #product1 .proc{
        width: 100%;
    }
    #banner{
        height: 40vh;
    }
    #sm-banner .banner-box{
        height: 40vh;
    }
    #sm-banner .banner-box2{
        margin-top: 20px;
    }
    #banner3 .banner-box{
        width: 100%;
    }
    #newsletter{
        padding: 40px 20px;
    }
    #newsletter .form{
        width: 100%;
    }
    footer .copyright{
        text-align: start;
    }
    /* Single Product */
    #prodetail{
        display: flex;
        flex-direction: column;
    }
    #prodetail .single-pro-image{
        width: 100%;
        margin-right: 0;
    }
    #prodetail .single-pro-detail{
        width: 100%;
        padding-top: 30px;
    }
}


