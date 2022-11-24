<#
	Stop RabbitMq in Docker
#>
$name="some-rabbit"
docker stop $name 2>1 | out-null
docker rm $name 2>1 | out-null