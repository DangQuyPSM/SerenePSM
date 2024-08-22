import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { Pfk7121Row } from "./Pfk7121Row";

export namespace Pfk7121Service {
    export const baseUrl = 'Default/Pfk7121';

    export declare function Create(request: SaveRequest<Pfk7121Row>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<Pfk7121Row>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<Pfk7121Row>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<Pfk7121Row>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<Pfk7121Row>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<Pfk7121Row>>;

    export const Methods = {
        Create: "Default/Pfk7121/Create",
        Update: "Default/Pfk7121/Update",
        Delete: "Default/Pfk7121/Delete",
        Retrieve: "Default/Pfk7121/Retrieve",
        List: "Default/Pfk7121/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>Pfk7121Service)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}