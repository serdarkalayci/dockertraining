docker pull redis
docker run --name redisws --network host -d redis redis-server
docker exec -it redisws bash
ls
redis-cli
ping

SET first "firststring"
GET first
SETEX timer 10 "itsnowornever"
GET timer
SET mynumber "10"
INCR mynumber
GET mynumber

docker container stop redisws
docker container rm redisws

docker volume create redisdata
docker run --name redisws -v redisdata:/data --network host -d redis redis-server

docker run -p 6379:6379 --name redisws -d redis
