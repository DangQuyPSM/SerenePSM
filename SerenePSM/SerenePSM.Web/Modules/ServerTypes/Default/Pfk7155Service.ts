import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { Pfk7155Row } from "./Pfk7155Row";

export namespace Pfk7155Service {
    export const baseUrl = 'Default/Pfk7155';

    export declare function Create(request: SaveRequest<Pfk7155Row>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<Pfk7155Row>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<Pfk7155Row>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<Pfk7155Row>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<Pfk7155Row>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<Pfk7155Row>>;

    export const Methods = {
        Create: "Default/Pfk7155/Create",
        Update: "Default/Pfk7155/Update",
        Delete: "Default/Pfk7155/Delete",
        Retrieve: "Default/Pfk7155/Retrieve",
        List: "Default/Pfk7155/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>Pfk7155Service)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}