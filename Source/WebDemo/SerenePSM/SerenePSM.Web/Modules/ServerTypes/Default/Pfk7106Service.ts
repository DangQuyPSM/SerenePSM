import { ServiceOptions, serviceRequest } from "@serenity-is/corelib";
import { DeleteRequest } from "../Services/DeleteRequest";
import { DeleteResponse } from "../Services/DeleteResponse";
import { ListRequest } from "../Services/ListRequest";
import { ListResponse } from "../Services/ListResponse";
import { RetrieveRequest } from "../Services/RetrieveRequest";
import { RetrieveResponse } from "../Services/RetrieveResponse";
import { SaveRequest } from "../Services/SaveRequest";
import { SaveResponse } from "../Services/SaveResponse";
import { Pfk7106Row } from "./Pfk7106Row";

export namespace Pfk7106Service {
    export const baseUrl = 'Default/Pfk7106';

    export declare function Create(request: SaveRequest<Pfk7106Row>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<Pfk7106Row>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<Pfk7106Row>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<Pfk7106Row>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<Pfk7106Row>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<Pfk7106Row>>;

    export const Methods = {
        Create: "Default/Pfk7106/Create",
        Update: "Default/Pfk7106/Update",
        Delete: "Default/Pfk7106/Delete",
        Retrieve: "Default/Pfk7106/Retrieve",
        List: "Default/Pfk7106/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>Pfk7106Service)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}