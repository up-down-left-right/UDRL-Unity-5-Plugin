# UDLR-Unity-5-Plugin

Plugin to integrate UDLR service into a Unity 5 game. 

## Resources

- Trophies
  - all GET api.updownleftright.com/trohpies
  - redeemed GET api.updownleftright.com/trophies/redeemed 
  - show GET api.updownleftright.com/trohpies/{trophy}
- Rewards
  - all GET api.updownleftright.com/rewards
  - redeemed GET api.updownleftright.com/rewards/redeemed
  - show GET api.updownleftright.com/rewards/{trophy}
- Points
  - balance GET api.updownleftirhgt.com/points/balance
  - convert points to xp (buy) POST api.updownleftright.com/points/....
- User
  - info is returned on auth

## Auth

FB id and token

Could use game center id later

## On App Close or Backgrounded

Ping server at POST api.updownleftright.com/game_session?status=pause|resume
