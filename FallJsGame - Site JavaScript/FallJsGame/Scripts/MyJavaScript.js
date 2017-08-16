//objects
function enemyController(environment) {
    this.enemyNum = 0;
    this.update = function () {
        var enemy = document.getElementsByClassName("enemy");
        for (var i = 0; i < this.enemyNum; i++) {
            //enemy falling
            enemy[i].style.marginTop = (parseInt(enemy[i].style.marginTop) + 10) + "px";
            if (parseInt(enemy[i].style.marginTop) + environment.characterHeight > environment.height) {
                enemy[i].remove();
                this.enemyNum--;
            }
        }
    };
    this.spawnEnemy = function () {
        var iDiv = document.createElement('div');
        iDiv.className = 'enemy';
        iDiv.style.marginLeft = (Math.random() * (environment.width - environment.characterWidth)) + "px";
        iDiv.style.marginTop = "0px";
        iDiv.style.border = "0px";
        iDiv.style.height = environment.characterHeight + "px";
        iDiv.style.width = environment.characterWidth + "px";
        document.getElementsByClassName('gamescene')[0].appendChild(iDiv);
    };
    this.getEnemyArray = function () {
        return document.getElementsByClassName("enemy");
    };
}

function coliderChecker(player, enemy, environment) {
    this.update = function () {
        var enemyAray = enemy.getEnemyArray();
        for (var i = 0; i < enemy.enemyNum; i++) {
            //eney colider
            if (!(parseInt(enemyAray[i].style.marginTop) > player.getMarginTop() + environment.characterHeight
                || parseInt(enemyAray[i].style.marginTop) + environment.characterHeight < player.getMarginTop()
                || parseInt(enemyAray[i].style.marginLeft) > player.getMarginLeft() + environment.characterWidth
                || parseInt(enemyAray[i].style.marginLeft) + environment.characterWidth < player.getMarginLeft())) {
                //cookie score
                adaugaScorNou(timePlayed);
                //other stuff
                isRunning = false;
                restartGameScene(enemy);//location.reload();
            }
        }
    };
}

function environmentSetter(width, height) {
    this.width = width;
    this.height = height;
    this.characterWidth = this.width * .05;
    this.characterHeight = this.height * .05;
    this.canvas = document.getElementsByClassName("gamescene")[0];
    this.canvas.style.height = this.height + "px";
    this.canvas.style.width = this.width + "px";
}

function playerController(environment) {
    this.speed = 10;
    this.playerDOM = document.getElementsByClassName("player")[0];
    this.playerTopPosition = environment.height * .89; //save top position because we need it later and it is constant
    this.playerDOM.style.marginTop = this.playerTopPosition + "px";
    this.playerDOM.style.marginLeft = (environment.width - environment.characterWidth) * .5 + "px";
    this.playerDOM.style.height = environment.characterHeight + "px";
    this.playerDOM.style.width = environment.characterWidth + "px";
    this.moveLeft = function () {
        this.playerDOM.style.marginLeft = this.getMarginLeft() - 10 + "px";
    };
    this.moveRight = function () {
        this.playerDOM.style.marginLeft = this.getMarginLeft() + 10 + "px";
    };
    this.getMarginTop = function () {
        return parseInt(this.playerDOM.style.marginTop);
    };
    this.getMarginLeft = function () {
        return parseInt(this.playerDOM.style.marginLeft);
    };
}


//functions
function transformTimeFromMilliseconds(time) {
    var locTime = time;
    var secunde = 0;
    var minute = 0;
    var ore = 0;
    while (locTime > 999) {
        secunde++;
        locTime -= 1000;
        if (secunde > 59) {
            minute++;
            secunde = 0;
        }
        if (minute > 59) {
            ore++;
            minute = 0;
        }
    }
    var secStr = secunde < 10 ? "0" + secunde : secunde;
    var minStr = minute < 10 ? "0" + minute : minute;
    var oreStr = ore < 10 ? "0" + ore : ore;
    return oreStr + ":" + minStr + ":" + secStr;
}

function adaugaScorNou(time) {
    $("#scoreId").text(timePlayed);
    var dialog = $("#dialog-form").dialog({
        modal: true,
        buttons: {
            Ok: function () {
                userName = dialog.find("form")[0]["name"].value;
                $(this).dialog("close");
            }
        },
        close: function (event, ui) {
            var scoreArrayObj = getScoreFromCookies();
            var temp1 = time;
            for (i = 0; i < 5; i++) {
                if (scoreArrayObj[i].Score < temp1) {
                    var temp2 = scoreArrayObj[i];
                    scoreArrayObj[i] = { Name: userName, Score: temp1 };
                    temp1 = temp2.Score;
                }
            }
            $.cookie("score", JSON.stringify(scoreArrayObj), { expires: 365 });
        }
    });
    dialog.find("form").on("submit", function (event) {
        event.preventDefault();
    });
}

function getScoreFromCookies() {
    if (typeof ($.cookie("score")) == "undefined") {
        var objArr = [
            { Name: "Empty", Score: 0 },
            { Name: "Empty", Score: 0 },
            { Name: "Empty", Score: 0 },
            { Name: "Empty", Score: 0 },
            { Name: "Empty", Score: 0 }];
        $.cookie("score", JSON.stringify(objArr));
    }
    return JSON.parse($.cookie("score"));
}

function restartGameScene(enemy) {
    cleanEnemy = true;
    tymeBetweenEnemySpawnCountDown = tymeBetweenEnemySpawn;
    timePlayed = 0;
    document.getElementById("play").style.visibility = "visible";
    document.getElementById("pause").style.visibility = "hidden";
}

//variable tyming
var isRunning = false;
var speed = 100;
var tymeBetweenEnemySpawn = 500;
var tymeBetweenEnemySpawnCountDown = tymeBetweenEnemySpawn;
var timePlayed = 0;
var userName = "";
var cleanEnemy = false;

//other

$(document).ready(function () {

    //create scene
    var environment = new environmentSetter(900, 600);
    var enemy = new enemyController(environment);
    var player = new playerController(environment);
    var colider = new coliderChecker(player, enemy, environment);




    //pause
    $("#pause, #play").click(function () {
        if (isRunning) {
            isRunning = false;
            firstTimePress = true;
            document.getElementById("play").style.visibility = "visible";
            document.getElementById("pause").style.visibility = "hidden";
        }
        else {
            isRunning = true;
            document.getElementById("play").style.visibility = "hidden";
            document.getElementById("pause").style.visibility = "visible";
        }
    });






    //player movement
    //a= 65     left= 37
    /////////////////////////s= 83     down= 40
    //d= 68     right= 39
    /////////////////////////w= 87     up= 38

    $(document).keydown(function (e) {
        if (isRunning) {
            //this is player moovement
            keyPressed = e.keyCode;
            var playerPositionLeft = player.getMarginLeft(); //increase performance
            if (e.keyCode == 65 || e.keyCode == 37) {
                if (playerPositionLeft - 10 > 0) {
                    player.moveLeft();
                }
            }
            else if (e.keyCode == 68 || e.keyCode == 39) {
                if (playerPositionLeft < environment.width - environment.characterWidth - 10) {
                    player.moveRight();
                }
            }
        }
    });
   
    setInterval(function () {
        //this interval is for enemy
        if (isRunning) {
            enemy.update();
            colider.update();
        }
        if (cleanEnemy) {
            $(".enemy").remove();
            cleanEnemy = false;
            enemy.enemyNum = 0;
        }
    }, speed)

    setInterval(function () {
        //this interval is for increase enemy
        if (isRunning) {
            while (tymeBetweenEnemySpawnCountDown < 0) {
                enemy.spawnEnemy();
                enemy.enemyNum++;
                if (tymeBetweenEnemySpawn > 50) {
                    tymeBetweenEnemySpawn = tymeBetweenEnemySpawn - 1;
                }
                else if (tymeBetweenEnemySpawn != 50) {
                    tymeBetweenEnemySpawn = 50;
                }
                tymeBetweenEnemySpawnCountDown = tymeBetweenEnemySpawn;
            }
            tymeBetweenEnemySpawnCountDown = tymeBetweenEnemySpawnCountDown - 50;
        }
    }, 50);

    setInterval(function () {
        //time update

        if (isRunning) {
            timePlayed += 100;
        }
        document.getElementById("time").innerHTML = transformTimeFromMilliseconds(timePlayed);

    }, 100);

    

    //jQuery
    $("#top").click(function () {
        //check if is empty
        if (typeof ($.cookie("score")) == "undefined") {
            var objArr = [
                { Name: "Empty", Score: 0 },
                { Name: "Empty", Score: 0 },
                { Name: "Empty", Score: 0 },
                { Name: "Empty", Score: 0 },
                { Name: "Empty", Score: 0 }];
            $.cookie("score", JSON.stringify(objArr));
        }
        //just do it :))
        var score = JSON.parse($.cookie("score"));
        var ul = $("#score");
        ul.html("");
        $.each(score, function (i, data) {
            $("<li/>", {}).text(data.Name + "  " + data.Score).appendTo(ul);
        }) 
        $("#dialog").dialog({
            modal: true,
            buttons: {
                Ok: function () {
                    $(this).dialog("close");
                }
            }
        });
    });

});