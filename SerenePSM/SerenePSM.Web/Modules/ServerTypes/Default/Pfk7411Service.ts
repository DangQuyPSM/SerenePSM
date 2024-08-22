import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { Pfk7411Row } from "./Pfk7411Row";

export namespace Pfk7411Service {
    export const baseUrl = 'Default/Pfk7411';

    export declare function Create(request: SaveRequest<Pfk7411Row>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<Pfk7411Row>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<Pfk7411Row>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<Pfk7411Row>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<Pfk7411Row>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<Pfk7411Row>>;

    export const Methods = {
        Create: "Default/Pfk7411/Create",
        Update: "Default/Pfk7411/Update",
        Delete: "Default/Pfk7411/Delete",
        Retrieve: "Default/Pfk7411/Retrieve",
        List: "Default/Pfk7411/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>Pfk7411Service)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}