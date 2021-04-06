# How to generate proto to ts


1. create the output folder first e.g. /generated (otherwise it will error)
2. from terminal, navigate to /protos folder
3. execute the command below

```

>> protoc --plugin=protoc-gen-ts="C:\Users\MK\Documents\Code\angular-grpc\node_modules\.bin\protoc-gen-ts.cmd" --js_out="import_style=commonjs,binary:../generated" --ts_out="service=grpc-web:../generated" country.proto


This works but it creates sub folders in the generated folder, the protoc-gen-ts is much to improve :P
>> ~~protoc --plugin=protoc-gen-ts="C:\Users\MK\Documents\Code\angular-grpc\node_modules\.bin\protoc-gen-ts.cmd" --js_out="import_style=commonjs,binary:src/app/generated" --ts_out="service=grpc-web:src/app/generated" ./src/app/protos/country.proto~~

```