<#
	Run RabbitMq in the background in Docker
	See: https://hub.docker.com/_/rabbitmq/
#>
$name="some-rabbit"
docker stop $name 2>1 | out-null
docker rm $name 2>1 | out-null
docker pull rabbitmq:3-alpine
docker run -d --hostname my-rabbit --name some-rabbit -p 8080:15672 -p 5672:5672 rabbitmq:3-management-alpine