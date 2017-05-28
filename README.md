# Another-brick-off-the-wall

Проект по предметот Визуелно Програмирање изработен од:
-	Митров Горан, 151002
-	Клинчаров Душко, 151024
-	Попов Стефан, 151165

## Опис на апликацијата

Апликацијата што ја развиваме е едноставна игра која наликува на игрите кои биле актуелни пред десетина години и може да се пронајде под различни имиња како *Break ball*, *Break bricks* и слично. Целта на играта е со топчето да се срушат сите тули кои се наоѓаат на ѕидот, а доколку играта се заврши за помалку од 3 минути, секоја секунда помалку носи бонус поени. Притоа со помош на таканаречен лизгач се контролира насоката на топчето и тоа не треба да падне под него бидејќи така се губи живот. Играта започнува со 3 животи, но во меѓувреме бројот на животи може да се зголеми поради тоа што понекогаш при рушената тула може да се појави награда која треба да се фати со лизгачот. 


## Стартување на апликацијата

![Почетна состојба на апликацијата](https://github.com/DushkoKlincharov/Another-brick-off-the-wall/blob/master/GitImages/MainPage.PNG)

На сликата може да се погледне почетната состојба на апликацијата. При кликање на копчето *About* се отвора нова форма која кажува кратки информации за играта и како да се игра. На копчето *High Scores* се прикажува форма со топ 5 играчи по освоени поени. Може да се избере едно од трите нивоа:
-	Easy
-	Medium
-	Hard

кое нуди различна поставеност на тулите, различна брзина на топчето и различна големина на лизгачот. На копчето *Play* стартува играта.

## Како се игра?

![Вклучена игра](https://github.com/DushkoKlincharov/Another-brick-off-the-wall/blob/master/GitImages/startGame.PNG)

На сликата е прикажано третото по тежина ниво. Пред започнувањето на играта, а исто така и по губењето на живот и пред продолжувањето со играта се одбројуваат три секунди за да играчот се подтови за играње. Во тие три секунди не може ни да го поместува лизгачот. Во долниот дел на сликата може да се забележат бројот на животи, бројот на собрани поени и времето поминато дотогаш. Играчот го придвижува лизгачот со помош на левата и десната стрелка од тастатурата. На долната слика е прикажана како изгледа наградата која може да ја добие играчот, а наградите се добивање на живот, зголемување на должината на лизгачот, но и намалување на должината на лизгачот на одредено време (во случајот 5 секунди). За тоа која награда со која боја е претставена може да се прочита во *About* делот на почетокот на играта.

![Награда](https://github.com/DushkoKlincharov/Another-brick-off-the-wall/blob/master/GitImages/Reward.PNG)

## Имплементација на апликацијата

При имплементацијата на апликацијата е искористен еден вид на MVC архитектура каде моделот го претставуваат класите **BALL**, **SLIDER**, **TILE** и **REWARD**. Како дел од моделот може да се смета и апстрактната класата **LEVEL** која во зависност од нивото на игра ги нуди потребните информации за брзината на топчето, големината на лизгачот и поставеноста на тулите.

- Model 

Голем дел од логиката на играта се темели на класата *Ball* бидејќи таму треба да се претстави движењето на топчето, како и допирот на топчето со лизгачот и одбивањето од него, а исто така и допирот на топчето со некоја од тулите и уништувањето на тулата при тој допир. Топчето е претставено со горната-лева точка, радиусот, а се чуваат и информации за аголот, брзината и брзина по Х и брзина по Y оска. Најкомплицираниот дел се токму математичките пресметки за допир на топчето со тулите, затоа што се обидовме да имплементираме 8 делови на допир и тоа: горе, долу, лево, десно, горен лев агол, горен десен агол, долен лев агол и долен десен агол, а со самото тоа и 8 различни начини на одбивање на топчето при судар со тулата. На кодовите кои следуваат може да се погледне основниот метод *collide* кој според начините на судирање го менува аголот и правецот на движење на топчето, како и некои од методите во кои се проверува дали има настанато допир на топчето и тулите.

```
internal bool collides(Tile tile)
        {
            
            if (collideDown(tile) || collideUp(tile))
            {
                SpeedY = -SpeedY;
                return true;
            }
            if (collideLeft(tile) || collideRight(tile))
            {
                SpeedX = -SpeedX;
                return true;
            }
            if (collideDownRight(tile))
            {
                Angle = -(float)Math.PI * 7 / 4;
                SpeedX = (float)Math.Cos(Angle) * Speed;
                SpeedY = (float)Math.Sin(Angle) * Speed;
                return true;
            }
            if(collideDownLeft(tile))
            {
                Angle = -(float)Math.PI * 5 / 4;
                SpeedX = (float)Math.Cos(Angle) * Speed;
                SpeedY = (float)Math.Sin(Angle) * Speed;
                return true;
            }
            if (collideUpRight(tile))
            {
                Angle = -(float)Math.PI * 1 / 4;
                SpeedX = (float)Math.Cos(Angle) * Speed;
                SpeedY = (float)Math.Sin(Angle) * Speed;
                return true;
            }
            if (collideUpLeft(tile))
            {
                Angle = -(float)Math.PI * 3 / 4;
                SpeedX = (float)Math.Cos(Angle) * Speed;
                SpeedY = (float)Math.Sin(Angle) * Speed;
                return true;
            }
            return false;
        }
```

```
private bool collideDownLeft(Tile tile)
        {
            return Math.Abs(Y - tile.Y - Tile.HEIGHT) < delta && Math.Abs(X + Radius - tile.X) <= corner * 2
                || Math.Abs(X + Radius * 2 - tile.X) < delta && Math.Abs(Y + Radius - tile.Y - Tile.HEIGHT) <= corner;
        }
        private bool collideDown(Tile tile)
        {
            return Math.Abs(Y - tile.Y - Tile.HEIGHT) < delta && tile.X + corner * 2 <= X + Radius
                && X + Radius <= tile.X + tile.Width - corner * 2;
        }
        private bool collideDownRight(Tile tile)
        {
            return Math.Abs(Y - tile.Y - Tile.HEIGHT) < delta && Math.Abs(X + Radius - tile.X - tile.Width) <= corner * 2
                || Math.Abs(X - tile.X - tile.Width) < delta && Math.Abs(Y + Radius - tile.Y - Tile.HEIGHT) <= corner;
        }
        private bool collideRight(Tile tile)
        {
            return Math.Abs(X - tile.X - tile.Width) < delta && tile.Y + corner < Y + Radius
                && Y + Radius <= tile.Y + Tile.HEIGHT - corner;
        }

        private bool collideLeft(Tile tile)
        {
            return Math.Abs(X + Radius * 2 - tile.X) < delta && tile.Y + corner <= Y + Radius &&
                Y + Radius <= tile.Y + Tile.HEIGHT - corner;
        }
        private bool collideUpLeft(Tile tile)
        {
            return Math.Abs(X + Radius * 2 - tile.X) < delta && Math.Abs(tile.Y - Y - Radius) <= corner
                || Math.Abs(Y + Radius * 2 - tile.Y) < delta && Math.Abs(X + Radius - tile.X) <= corner * 2;
        }
        private bool collideUp(Tile tile)
        {
            return Math.Abs(Y + Radius * 2 - tile.Y) < delta && tile.X + corner * 2 <= X + Radius
                && X + Radius <= tile.X + tile.Width - corner * 2;
        }
         
        private bool collideUpRight(Tile tile)
        {
            return Math.Abs(Y + Radius * 2 - tile.Y) < delta && Math.Abs(X + Radius - tile.X - tile.Width) <= corner * 2
                || Math.Abs(X - tile.X - tile.Width) < delta && Math.Abs(tile.Y - Y - Radius) <= corner;
        }
```

- Controller

Како контролер на апликацијата е класата **SCENE** која како свои податочни членки ги чува топчето, лизгачот, листа од тули кои се иницијализираат во конструкторот според одбраното ниво на играчот на почетокот при стартувањето на играта. За полесна имплементација на моделот во класата *Scene* се чуваат статички променливи за број на редови, број на колони како и за големината на едно квадратно поле од овој grid. Во контролерот имаме методи во коишто имаме иницијализација на играта по загубен живот, како и за завршување на играта, но најважен е методот *TimerTick()* кој се случува на секои 15 милисекунди( времето на покренување на настанот е избрано да биде 15 како компромис на извршувањето на сите пресметки и движењето на топчето мазно, без подзакочување). Во гореспоменатиот метод имаме дополнителни методи од моделот кои служат за придвижување на топчето, придвижување на лизгачот, проверка за колизија на топчето со лизгачот или со тулите, како и проверка на допир на лизгачот со некоја од наградите. Во продолжение следува кодот кој го содржи овој главен метод на оваа класа.


```
// method when the timer ticks in 15 milliseconds

        public void TimerTick()
        {
            if (RewardCounter > 0)
            {
                RewardCounter--;
                if (RewardCounter == 0)
                {
                    RewardTheUser(Reward.Rwd, false);
                }
            }

            Ball.Move(); // the moving of the ball
            Ball.SliderCollider(Slider); // condition if ball touches with slider
            if (Ball.OutOfBounds(Slider))
                loseLife = true;
            
            MoveSlider(); // move the slider
            TilesCollisions(); // check for collisions of the ball with tiles
            if (Reward != null) // if there is reward it should move downwards 
            {
                Reward.Move(Slider);
                if (!Reward.forDelete && Slider.touchReward(Reward))
                {  // if slider touches the reward get the reward
                    RewardCounter = 350;
                    RewardTheUser(Reward.Rwd, true);
                    Reward.forDelete = true;
                }
                if (Reward.toNull && RewardCounter == 0) Reward = null;
            }
            
        }
        
```

- View

Како генерален View прозорец е формата *NewGame* каде се наоѓаат 'event handlers' за отчукувањето на часовникот, како и за притиснатите копчиња за придвижување на лизгачот. Има уште неколку прозорци за преглед, а на наредната слика е прикажан прозорецот каде се прикажуваат моменталните топ 5 резултати.

![High Scores View](https://github.com/DushkoKlincharov/Another-brick-off-the-wall/blob/master/GitImages/HighScores.PNG)

