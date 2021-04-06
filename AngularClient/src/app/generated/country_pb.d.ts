// package: 
// file: country.proto

import * as jspb from "google-protobuf";

export class EmptyRequest extends jspb.Message {
  serializeBinary(): Uint8Array;
  toObject(includeInstance?: boolean): EmptyRequest.AsObject;
  static toObject(includeInstance: boolean, msg: EmptyRequest): EmptyRequest.AsObject;
  static extensions: {[key: number]: jspb.ExtensionFieldInfo<jspb.Message>};
  static extensionsBinary: {[key: number]: jspb.ExtensionFieldBinaryInfo<jspb.Message>};
  static serializeBinaryToWriter(message: EmptyRequest, writer: jspb.BinaryWriter): void;
  static deserializeBinary(bytes: Uint8Array): EmptyRequest;
  static deserializeBinaryFromReader(message: EmptyRequest, reader: jspb.BinaryReader): EmptyRequest;
}

export namespace EmptyRequest {
  export type AsObject = {
  }
}

export class CountryReply extends jspb.Message {
  getId(): number;
  setId(value: number): void;

  getName(): string;
  setName(value: string): void;

  getDescription(): string;
  setDescription(value: string): void;

  serializeBinary(): Uint8Array;
  toObject(includeInstance?: boolean): CountryReply.AsObject;
  static toObject(includeInstance: boolean, msg: CountryReply): CountryReply.AsObject;
  static extensions: {[key: number]: jspb.ExtensionFieldInfo<jspb.Message>};
  static extensionsBinary: {[key: number]: jspb.ExtensionFieldBinaryInfo<jspb.Message>};
  static serializeBinaryToWriter(message: CountryReply, writer: jspb.BinaryWriter): void;
  static deserializeBinary(bytes: Uint8Array): CountryReply;
  static deserializeBinaryFromReader(message: CountryReply, reader: jspb.BinaryReader): CountryReply;
}

export namespace CountryReply {
  export type AsObject = {
    id: number,
    name: string,
    description: string,
  }
}

export class CountriesReply extends jspb.Message {
  clearCountriesList(): void;
  getCountriesList(): Array<CountryReply>;
  setCountriesList(value: Array<CountryReply>): void;
  addCountries(value?: CountryReply, index?: number): CountryReply;

  serializeBinary(): Uint8Array;
  toObject(includeInstance?: boolean): CountriesReply.AsObject;
  static toObject(includeInstance: boolean, msg: CountriesReply): CountriesReply.AsObject;
  static extensions: {[key: number]: jspb.ExtensionFieldInfo<jspb.Message>};
  static extensionsBinary: {[key: number]: jspb.ExtensionFieldBinaryInfo<jspb.Message>};
  static serializeBinaryToWriter(message: CountriesReply, writer: jspb.BinaryWriter): void;
  static deserializeBinary(bytes: Uint8Array): CountriesReply;
  static deserializeBinaryFromReader(message: CountriesReply, reader: jspb.BinaryReader): CountriesReply;
}

export namespace CountriesReply {
  export type AsObject = {
    countriesList: Array<CountryReply.AsObject>,
  }
}

