import {expect} from 'chai';
import {mathEnforcer} from '../mathEnforcer.js';

describe('Math Enforcer', () => {

    describe('addFive Method', () => {
        it('Should add 5 to the input number', () => {
            const result = mathEnforcer.addFive(10);
            expect (result).to.equal(15);
        });

        it('Should add 5 to negative input number', () => {
            const result = mathEnforcer.addFive(-10);
            expect (result).to.equal(-5);
        });

        it('Should add 5 to decimal input number', () => {
            const result = mathEnforcer.addFive(5.5);
            expect (result).to.equal(10.5);
        });
    
        it('Should return undefined when non-number input is given', () => {
            expect (mathEnforcer.addFive(true)).to.be.undefined;
            expect (mathEnforcer.addFive('5')).to.be.undefined;
            expect (mathEnforcer.addFive('')).to.be.undefined;
            expect (mathEnforcer.addFive(null)).to.be.undefined;
            expect (mathEnforcer.addFive(undefined)).to.be.undefined;
            expect (mathEnforcer.addFive([1])).to.be.undefined;
            expect (mathEnforcer.addFive({input: 1 })).to.be.undefined;
        });
    });

    describe('subtractTen Method', () => {
        it('Should subtract 10 from the input number', () => {
            const result = mathEnforcer.subtractTen(10);
            expect (result).to.equal(0);
        });

        it('Should subtract 10 from negative input number', () => {
            const result = mathEnforcer.subtractTen(-10);
            expect (result).to.equal(-20);
        });

        it('Should subtract 10 from decimal input number', () => {
            const result = mathEnforcer.subtractTen(15.5);
            expect (result).to.equal(5.5);
        });

        it('Should return undefined when non-number input is passed', () => {
            expect (mathEnforcer.subtractTen(true)).to.be.undefined;
            expect (mathEnforcer.subtractTen('5')).to.be.undefined;
            expect (mathEnforcer.subtractTen('')).to.be.undefined;
            expect (mathEnforcer.subtractTen(null)).to.be.undefined;
            expect (mathEnforcer.subtractTen(undefined)).to.be.undefined;
            expect (mathEnforcer.subtractTen([1])).to.be.undefined;
            expect (mathEnforcer.subtractTen({input: 1 })).to.be.undefined;
        });
    });

    describe('sum Method', () => {
        it('Should sum the input numbers', () => {
            const result = mathEnforcer.sum(10, 5);
            expect (result).to.equal(15);
        });

        it('Should sum two zeros', () => {
            const result = mathEnforcer.sum(0, 0);
            expect (result).to.equal(0);
        });
        it('Should sum the input negative numbers', () => {
            const result = mathEnforcer.sum(-20, -5);
            expect (result).to.equal(-25);
        });

        it('Should sum the decimal input numbers', () => {
            const result = mathEnforcer.sum(5.5, 4.6);
            expect (result).to.equal(10.1);
        });

        it('Should sum negative decimal input numbers', () => {
            const result = mathEnforcer.sum(-5.5, -4.6);
            expect (result).to.be.closeTo(-10.1, 1, 'close');
        });
    
        it('Should return undefined when non-number inputs are given', () => {
            expect (mathEnforcer.sum(true, 1)).to.be.undefined;
            expect (mathEnforcer.sum('5', 5)).to.be.undefined;
            expect (mathEnforcer.sum('', null)).to.be.undefined;
            expect (mathEnforcer.sum(null, 10)).to.be.undefined;
            expect (mathEnforcer.sum(-10, undefined)).to.be.undefined;
            expect (mathEnforcer.sum(10, [1, 2])).to.be.undefined;
            expect (mathEnforcer.sum({input: 1 }, 10)).to.be.undefined;
        });
    });
});