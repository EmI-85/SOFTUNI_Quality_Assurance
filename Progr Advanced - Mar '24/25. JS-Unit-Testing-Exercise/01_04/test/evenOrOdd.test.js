import { expect } from 'chai';
import {isOddOrEven} from '../evenOrOdd.js';

//it('Should be ok', () => {
//    expect(true).to.be.true;
//});

describe('Even Or Odd', () => {
    it('Should return odd when given an odd number of symbols in string', () => {
        const input = 'aaa';
        const expectedResult = 'odd';
        const actualResult = isOddOrEven(input);

        expect(actualResult).to.equal(expectedResult);
    });

    it('Should return even when given an even number of symbols in string', () => {
        const result = isOddOrEven('bbbb');
        expect(result).to.equal('even');
    });

    it('Should return undefined when non-string input is given', () => {
        expect(isOddOrEven(7)).to.be.undefined;
        expect(isOddOrEven([])).to.be.undefined;
        expect(isOddOrEven(null)).to.be.undefined;
        expect(isOddOrEven()).to.be.undefined;
        expect(isOddOrEven(NaN)).to.be.undefined;
    });

    it('Should return even when given an empty string', () => {
        expect(isOddOrEven('')).to.equal('even');
    });

    it('Should return correct output when given multiple strings', () => {
        expect(isOddOrEven('foo')).to.equal('odd');
        expect(isOddOrEven('foobar')).to.equal('even');
    });
});