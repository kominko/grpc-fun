// package: 
// file: country.proto

var country_pb = require("./country_pb");
var grpc = require("@improbable-eng/grpc-web").grpc;

var Country = (function () {
  function Country() {}
  Country.serviceName = "Country";
  return Country;
}());

Country.GetAll = {
  methodName: "GetAll",
  service: Country,
  requestStream: false,
  responseStream: false,
  requestType: country_pb.EmptyRequest,
  responseType: country_pb.CountriesReply
};

exports.Country = Country;

function CountryClient(serviceHost, options) {
  this.serviceHost = serviceHost;
  this.options = options || {};
}

CountryClient.prototype.getAll = function getAll(requestMessage, metadata, callback) {
  if (arguments.length === 2) {
    callback = arguments[1];
  }
  var client = grpc.unary(Country.GetAll, {
    request: requestMessage,
    host: this.serviceHost,
    metadata: metadata,
    transport: this.options.transport,
    debug: this.options.debug,
    onEnd: function (response) {
      if (callback) {
        if (response.status !== grpc.Code.OK) {
          var err = new Error(response.statusMessage);
          err.code = response.status;
          err.metadata = response.trailers;
          callback(err, null);
        } else {
          callback(null, response.message);
        }
      }
    }
  });
  return {
    cancel: function () {
      callback = null;
      client.close();
    }
  };
};

exports.CountryClient = CountryClient;

